﻿using SC2APIProtocol;
using Sharky.Managers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Sharky
{
    public class UnitCalculation
    {
        public Unit Unit { get; set; }
        /// <summary>
        /// TODO: currently only set for enemies, allies is just the same as the current
        /// </summary>
        public Unit PreviousUnit { get; set; }
        public Vector2 Start { get; set; }
        public Vector2 End { get; set; }
        public float DamageRadius { get; set; }
        public float EstimatedCooldown { get; set; }
        public bool DamageGround { get; set; }
        public bool DamageAir { get; set; }
        public float Damage { get; set; }
        public float Dps { get; set; }
        public float Range { get; set; }
        public Weapon Weapon { get; set; }
        public List<Weapon> Weapons { get; set; }
        public float SimulatedHitpoints { get; set; }
        public float SimulatedHealPerSecond { get; set; }
        public IEnumerable<SC2APIProtocol.Attribute> Attributes { get; set; }

        /// <summary>
        /// enemies this unit can attack
        /// </summary>
        public List<UnitCalculation> EnemiesInRange { get; set; }

        /// <summary>
        /// enemies that can hit this unit
        /// </summary>
        public List<UnitCalculation> EnemiesInRangeOf { get; set; }

        public List<UnitCalculation> NearbyAllies { get; set; }
        public List<UnitCalculation> NearbyEnemies { get; set; }

        /// <summary>
        /// list of units attacking this unit
        /// </summary>
        public ConcurrentBag<ulong> Attackers { get; set; }

        public List<UnitClassification> UnitClassifications { get; set; }

        public UnitCalculation(Unit previousUnit, Unit unit, int repairers, UnitDataManager unitDataManager, SharkyOptions sharkyOptions)
        {
            PreviousUnit = previousUnit;
            Unit = unit;

            UnitClassifications = new List<UnitClassification>();
            if (unitDataManager.UnitData[unit.UnitType].Attributes.Contains(SC2APIProtocol.Attribute.Structure))
            {
            }
            else if (unit.UnitType == (uint)UnitTypes.TERRAN_SCV || unit.UnitType == (uint)UnitTypes.TERRAN_MULE || unit.UnitType == (uint)UnitTypes.PROTOSS_PROBE || unit.UnitType == (uint)UnitTypes.ZERG_DRONE || unit.UnitType == (uint)UnitTypes.ZERG_QUEEN)
            {
                UnitClassifications.Add(UnitClassification.Worker);
            }
            else
            {
                UnitClassifications.Add(UnitClassification.ArmyUnit);
            }

            var unitRange = unitDataManager.GetRange(unit);
            if (unitRange == 0)
            {
                Range = 0;
            }
            else
            {
                Range = unitRange + unit.Radius;
            }

            var endX = (float)Math.Sin(unit.Facing) * Range;
            var endY = (float)Math.Cos(unit.Facing) * Range;
            Start = new Vector2(unit.Pos.X, unit.Pos.Y);
            End = new Vector2(endX + unit.Pos.X, endY + unit.Pos.Y);

            DamageRadius = 1; // TODO: get damage radius
            EstimatedCooldown = 0; // TODO: get estimated cooldown

            DamageAir = false;
            if (unitDataManager.CanAttackAir(unit.UnitType))
            {
                DamageAir = true;
            }
            DamageGround = false;
            if (unitDataManager.CanAttackGround(unit.UnitType))
            {
                DamageGround = true;
            }
            Damage = unitDataManager.GetDamage(unit);
            Dps = unitDataManager.GetDps(unit);
            Weapon = unitDataManager.GetWeapon(unit);
            Weapons = unitDataManager.UnitData[unit.UnitType].Weapons.ToList();
            if (Weapons == null)
            {
                Weapons = new List<Weapon>();
                if (Weapon != null)
                {
                    Weapons.Add(Weapon);
                }
            }

            SimulatedHitpoints = Unit.Health + Unit.Shield;
            if (Unit.BuffIds.Contains((uint)Buffs.IMMORTALOVERLOAD))
            {
                SimulatedHitpoints += 100;
            }
            if (unit.UnitType == (uint)UnitTypes.PROTOSS_WARPPRISM)
            {
                SimulatedHitpoints += 500;
            }

            if (unitDataManager.ZergTypes.Contains((UnitTypes)Unit.UnitType))
            {
                SimulatedHealPerSecond = 0.38f;
            }
            else if (repairers > 0 && unitDataManager.UnitData[unit.UnitType].Attributes.Contains(SC2APIProtocol.Attribute.Mechanical))
            {
                SimulatedHealPerSecond = (float)(unit.HealthMax / (unitDataManager.UnitData[unit.UnitType].BuildTime / sharkyOptions.FramesPerSecond)) * repairers;
            }
            else if (Unit.UnitType == (uint)UnitTypes.TERRAN_MEDIVAC && Unit.Energy > 10)
            {
                SimulatedHealPerSecond = 12.6f;
            }
            else if (Unit.UnitType == (uint)UnitTypes.ZERG_QUEEN && Unit.Energy >= 50)
            {
                SimulatedHealPerSecond = 20;
            }
            else
            {
                SimulatedHealPerSecond = 0;
            }

            if (Unit.UnitType == (uint)UnitTypes.TERRAN_BUNKER && Unit.BuildProgress == 1) // assume 4 marines
            {
                Range = 6;
                DamageAir = true;
                DamageGround = true;
                Damage = 6;
                Dps = Damage * 4 / 0.61f;
            }

            Attributes = unitDataManager.UnitData[unit.UnitType].Attributes;

            EnemiesInRange = new List<UnitCalculation>();
            EnemiesInRangeOf = new List<UnitCalculation>();
            NearbyAllies = new List<UnitCalculation>();
            NearbyEnemies = new List<UnitCalculation>();
            Attackers = new ConcurrentBag<ulong>();
        }

        public float SimulatedDamagePerSecond(IEnumerable<SC2APIProtocol.Attribute> includedAttributes, bool air, bool ground)
        {
            if (Unit.UnitType == (uint)UnitTypes.TERRAN_BUNKER) // assume 4 marines
            {
                return 24 / 0.61f;
            }

            if (Unit.UnitType == (uint)UnitTypes.PROTOSS_HIGHTEMPLAR && Unit.Energy > 75)
            {
                return 25 * 3; // storm does 25 damage per second, probably will hit 3 units
            }
            if (Unit.UnitType == (uint)UnitTypes.PROTOSS_DISRUPTOR && ground)
            {
                return 145;
            }
            if (Unit.UnitType == (uint)UnitTypes.ZERG_INFESTOR || Unit.UnitType == (uint)UnitTypes.ZERG_INFESTORBURROWED && Unit.Energy >= 75)
            {
                return 100; // fungal growth
            }
            if (Unit.UnitType == (uint)UnitTypes.ZERG_VIPER && Unit.Energy >= 75)
            {
                return 100;
            }

            if (Weapon == null || Weapon.Damage == 0) { return 0; }
            if (air && !ground && !DamageAir) { return 0; }
            if (ground && !air && !DamageGround) { return 0; }

            float damage = Damage;
            var damageBonus = Weapon.DamageBonus.FirstOrDefault(d => includedAttributes.Contains(d.Attribute));
            if (damageBonus != null)
            {
                damage += damageBonus.Bonus;
            }

            if (Unit.UnitType == (uint)UnitTypes.TERRAN_SIEGETANKSIEGED)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.TERRAN_PLANETARYFORTRESS)
            {
                damage *= 3;
            }
            if (Unit.UnitType == (uint)UnitTypes.TERRAN_THOR && air)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.TERRAN_LIBERATOR)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.TERRAN_HELLIONTANK)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.TERRAN_HELLION)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.TERRAN_WIDOWMINEBURROWED)
            {
                damage *= 2;
            }

            if (Unit.UnitType == (uint)UnitTypes.PROTOSS_ARCHON)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.PROTOSS_COLOSSUS)
            {
                damage *= 3;
            }

            if (Unit.UnitType == (uint)UnitTypes.ZERG_BANELING || Unit.UnitType == (uint)UnitTypes.ZERG_BANELINGBURROWED)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.ZERG_ULTRALISK)
            {
                damage *= 2;
            }
            if (Unit.UnitType == (uint)UnitTypes.ZERG_LURKERMPBURROWED)
            {
                damage *= 2;
            }

            return damage / Weapon.Speed;
        }
    }
}
