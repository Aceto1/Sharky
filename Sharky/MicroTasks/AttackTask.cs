﻿using SC2APIProtocol;
using Sharky.Managers;
using Sharky.MicroControllers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Sharky.MicroTasks
{
    public class AttackTask : MicroTask
    {
        IMicroController MicroController;
        ITargetingManager TargetingManager;
        UnitManager UnitManager;
        DefenseService DefenseService;
        MacroData MacroData;
        AttackData AttackData;

        public AttackTask(IMicroController microController, ITargetingManager targetingManager, UnitManager unitManager, DefenseService defenseService, MacroData macroData, AttackData attackData, int priority)
        {
            MicroController = microController;
            TargetingManager = targetingManager;
            UnitManager = unitManager;
            DefenseService = defenseService;
            MacroData = macroData;
            AttackData = attackData;
            Priority = priority;

            UnitCommanders = new List<UnitCommander>();
        }

        public override void ClaimUnits(ConcurrentDictionary<ulong, UnitCommander> commanders)
        {
            foreach (var commander in commanders)
            {
                if (!commander.Value.Claimed && commander.Value.UnitCalculation.UnitClassifications.Contains(UnitClassification.ArmyUnit))
                {
                    commander.Value.Claimed = true;
                    UnitCommanders.Add(commander.Value);
                }
            }
        }

        public override IEnumerable<SC2APIProtocol.Action> PerformActions(int frame)
        {
            var vectors = UnitCommanders.Select(u => new Vector2(u.UnitCalculation.Unit.Pos.X, u.UnitCalculation.Unit.Pos.Y));
            if (vectors.Count() > 0)
            {
                var average = new Vector2(vectors.Average(v => v.X), vectors.Average(v => v.Y));
                var trimmed = vectors.Where(v => Vector2.DistanceSquared(average, v) < 200);
                if (trimmed.Count() > 0)
                {
                    var trimmedAverage = new Point2D { X = trimmed.Average(v => v.X), Y = trimmed.Average(v => v.Y) };
                    AttackData.ArmyPoint = trimmedAverage;
                }
                else
                {
                    AttackData.ArmyPoint = new Point2D { X = average.X, Y = average.Y };
                }
            }
            else
            {
                AttackData.ArmyPoint = TargetingManager.AttackPoint;
            }

            var attackPoint = TargetingManager.GetAttackPoint(AttackData.ArmyPoint);

            if (!AttackData.CustomAttackFunction)
            {
                AttackData.Attacking = MacroData.FoodArmy >= AttackData.ArmyFoodAttack;
            }

            var attackingEnemies = UnitManager.SelfUnits.Where(u => u.Value.UnitClassifications.Contains(UnitClassification.ResourceCenter) || u.Value.UnitClassifications.Contains(UnitClassification.ProductionStructure)).SelectMany(u => u.Value.NearbyEnemies).Distinct();
            if (attackingEnemies.Count() > 0)
            {
                var armyPoint = new Vector2(AttackData.ArmyPoint.X, AttackData.ArmyPoint.Y);
                var distanceToAttackPoint = Vector2.DistanceSquared(armyPoint, new Vector2(attackPoint.X, attackPoint.Y));
                var closerEnemies = attackingEnemies.Where(e => Vector2.DistanceSquared(new Vector2(e.Unit.Pos.X, e.Unit.Pos.Y), armyPoint) < distanceToAttackPoint);
                if (closerEnemies.Count() > 0)
                {
                    return SplitArmy(frame, closerEnemies, attackPoint);
                }
            }

            if (AttackData.Attacking)
            {
                return MicroController.Attack(UnitCommanders, attackPoint, TargetingManager.DefensePoint, AttackData.ArmyPoint, frame);
            }
            else
            {
                return MicroController.Retreat(UnitCommanders, TargetingManager.DefensePoint, AttackData.ArmyPoint, frame);
            }
        }

        IEnumerable<SC2APIProtocol.Action> SplitArmy(int frame, IEnumerable<UnitCalculation> closerEnemies, Point2D attackPoint)
        {
            var actions = new List<SC2APIProtocol.Action>();

            var enemyGroups = DefenseService.GetEnemyGroups(closerEnemies);
            var availableCommanders = UnitCommanders.ToList();
            foreach (var enemyGroup in enemyGroups)
            {
                var selfGroup = DefenseService.GetDefenseGroup(enemyGroup, availableCommanders);
                if (selfGroup.Count() > 0)
                {
                    availableCommanders.RemoveAll(a => selfGroup.Any(s => a.UnitCalculation.Unit.Tag == s.UnitCalculation.Unit.Tag));

                    var groupVectors = selfGroup.Select(u => new Vector2(u.UnitCalculation.Unit.Pos.X, u.UnitCalculation.Unit.Pos.Y));
                    var groupPoint = new Point2D { X = groupVectors.Average(v => v.X), Y = groupVectors.Average(v => v.Y) };
                    var defensePoint = new Point2D { X = enemyGroup.FirstOrDefault().Unit.Pos.X, Y = enemyGroup.FirstOrDefault().Unit.Pos.Y };
                    actions.AddRange(MicroController.Attack(selfGroup, defensePoint, TargetingManager.DefensePoint, groupPoint, frame));
                }
            }

            if (availableCommanders.Count() > 0)
            {
                var groupVectors = availableCommanders.Select(u => new Vector2(u.UnitCalculation.Unit.Pos.X, u.UnitCalculation.Unit.Pos.Y));
                var groupPoint = new Point2D { X = groupVectors.Average(v => v.X), Y = groupVectors.Average(v => v.Y) };
                if (AttackData.Attacking)
                {
                    actions.AddRange(MicroController.Attack(availableCommanders, attackPoint, TargetingManager.DefensePoint, groupPoint, frame));
                }
                else
                {
                    actions.AddRange(MicroController.Attack(availableCommanders, new Point2D { X = closerEnemies.FirstOrDefault().Unit.Pos.X, Y = closerEnemies.FirstOrDefault().Unit.Pos.Y }, TargetingManager.DefensePoint, groupPoint, frame));
                }
            }

            return actions;
        }
    }
}
