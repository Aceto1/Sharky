namespace Sharky.TypeData
{
    public class TrainingDataService
    {
        public Dictionary<UnitTypes, TrainingTypeData> TrainingData()
        {
            return new Dictionary<UnitTypes, TrainingTypeData>
            {
                { UnitTypes.TERRAN_BARRACKSTECHLAB, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 50, Gas = 25, Ability = Abilities.BUILD_TECHLAB_BARRACKS, IsAddOn = true, Time = 18 } },
                { UnitTypes.TERRAN_BARRACKSREACTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 50, Gas = 50, Ability = Abilities.BUILD_REACTOR_BARRACKS, IsAddOn = true, Time = 36 } },

                { UnitTypes.PROTOSS_PROBE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_NEXUS }, Minerals = 50, Food = 1, Ability = Abilities.TRAIN_PROBE, Time = 12 } },
                { UnitTypes.PROTOSS_MOTHERSHIP, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_NEXUS }, Minerals = 300, Gas = 300, Food = 6, Ability = Abilities.TRAIN_MOTHERSHIP, Time = 79 } },
                { UnitTypes.PROTOSS_ZEALOT, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_GATEWAY, UnitTypes.PROTOSS_WARPGATE }, Minerals = 100, Food = 2, Ability = Abilities.TRAIN_ZEALOT, WarpInAbility = Abilities.TRAINWARP_ZEALOT, Time = 27 } },
                { UnitTypes.PROTOSS_SENTRY, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_GATEWAY, UnitTypes.PROTOSS_WARPGATE }, Minerals = 50, Gas = 100, Food = 2, Ability = Abilities.TRAIN_SENTRY, WarpInAbility = Abilities.TRAINWARP_SENTRY, Time = 23 } },
                { UnitTypes.PROTOSS_STALKER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_GATEWAY, UnitTypes.PROTOSS_WARPGATE }, Minerals = 125, Gas = 50, Food = 2, Ability = Abilities.TRAIN_STALKER, WarpInAbility = Abilities.TRAINWARP_STALKER, Time = 30 } },
                { UnitTypes.PROTOSS_ADEPT, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_GATEWAY, UnitTypes.PROTOSS_WARPGATE }, Minerals = 100, Gas = 25, Food = 2, Ability = Abilities.TRAIN_ADEPT, WarpInAbility = Abilities.TRAINWARP_ADEPT , Time = 30 } },
                { UnitTypes.PROTOSS_HIGHTEMPLAR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_GATEWAY, UnitTypes.PROTOSS_WARPGATE }, Minerals = 50, Gas = 150, Food = 2, Ability = Abilities.TRAIN_HIGHTEMPLAR, WarpInAbility = Abilities.TRAINWARP_HIGHTEMPLAR, Time = 39 } },
                { UnitTypes.PROTOSS_DARKTEMPLAR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_GATEWAY, UnitTypes.PROTOSS_WARPGATE }, Minerals = 125, Gas = 125, Food = 2, Ability = Abilities.TRAIN_DARKTEMPLAR, WarpInAbility = Abilities.TRAINWARP_DARKTEMPLAR, Time = 39 } },
                { UnitTypes.PROTOSS_OBSERVER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSFACILITY }, Minerals = 25, Gas = 75, Food = 1, Ability = Abilities.TRAIN_OBSERVER, Time = 21 } },
                { UnitTypes.PROTOSS_WARPPRISM, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSFACILITY }, Minerals = 250, Food = 2, Ability = Abilities.TRAIN_WARPPRISM, Time = 36 } },
                { UnitTypes.PROTOSS_IMMORTAL, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSFACILITY }, Minerals = 275, Gas = 100, Food = 4, Ability = Abilities.TRAIN_IMMORTAL, Time = 39 } },
                { UnitTypes.PROTOSS_COLOSSUS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSFACILITY }, Minerals = 300, Gas = 200, Food = 6, Ability = Abilities.TRAIN_COLOSSUS, Time = 54 } },
                { UnitTypes.PROTOSS_DISRUPTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSFACILITY }, Minerals = 150, Gas = 150, Food = 3, Ability = Abilities.TRAIN_DISRUPTOR, Time = 36 } },
                { UnitTypes.PROTOSS_PHOENIX, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_STARGATE }, Minerals = 150, Gas = 100, Food = 2, Ability = Abilities.TRAIN_PHOENIX, Time = 25 } },
                { UnitTypes.PROTOSS_ORACLE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_STARGATE }, Minerals = 150, Gas = 150, Food = 3, Ability = Abilities.TRAIN_ORACLE, Time = 37 } },
                { UnitTypes.PROTOSS_VOIDRAY, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_STARGATE }, Minerals = 250, Gas = 150, Food = 4, Ability = Abilities.TRAIN_VOIDRAY, Time = 43 } },
                { UnitTypes.PROTOSS_TEMPEST, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_STARGATE }, Minerals = 250, Gas = 175, Food = 5, Ability = Abilities.TRAIN_TEMPEST, Time = 43 } },
                { UnitTypes.PROTOSS_CARRIER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_STARGATE }, Minerals = 350, Gas = 250, Food = 6, Ability = Abilities.TRAIN_CARRIER, Time = 64 } },
                { UnitTypes.PROTOSS_ARCHON, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_HIGHTEMPLAR, UnitTypes.PROTOSS_DARKTEMPLAR }, Minerals = 0, Gas = 0, Food = 0, Ability = Abilities.MORPH_ARCHON, Time = 9 } },

                { UnitTypes.TERRAN_SCV, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_COMMANDCENTER, UnitTypes.TERRAN_ORBITALCOMMAND, UnitTypes.TERRAN_PLANETARYFORTRESS }, Minerals = 50, Food = 1, Ability = Abilities.TRAIN_SCV, Time = 12 } },
                { UnitTypes.TERRAN_MARINE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 50, Food = 1, Ability = Abilities.TRAIN_MARINE, Time = 18 } },
                { UnitTypes.TERRAN_MARAUDER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 100, Gas = 25, Food = 2, Ability = Abilities.TRAIN_MARAUDER, RequiresTechLab = true, Time = 21 } },
                { UnitTypes.TERRAN_REAPER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 50, Gas = 50, Food = 1, Ability = Abilities.TRAIN_REAPER, Time = 32 } },
                { UnitTypes.TERRAN_GHOST, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 150, Gas = 125, Food = 2, Ability = Abilities.TRAIN_GHOST, RequiresTechLab = true, Time = 29 } },
                { UnitTypes.TERRAN_HELLION, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 100, Food = 2, Ability = Abilities.TRAIN_HELLION, Time = 21 } },
                { UnitTypes.TERRAN_HELLIONTANK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 100, Food = 2, Ability = Abilities.TRAIN_HELLBAT, Time = 21 } },
                { UnitTypes.TERRAN_CYCLONE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 100, Gas = 50, Food = 2, Ability = Abilities.TRAIN_CYCLONE, Time = 32 } },
                { UnitTypes.TERRAN_SIEGETANK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 150, Gas = 125, Food = 3, Ability = Abilities.TRAIN_SIEGETANK, RequiresTechLab = true, Time = 32 } },
                { UnitTypes.TERRAN_WIDOWMINE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 75, Gas = 75, Food = 2, Ability = Abilities.TRAIN_WIDOWMINE, Time = 21 } },
                { UnitTypes.TERRAN_THOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 300, Gas = 200, Food = 6, Ability = Abilities.TRAIN_THOR, RequiresTechLab = true, Time = 43 } },
                { UnitTypes.TERRAN_VIKINGFIGHTER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 150, Gas = 75, Food = 2, Ability = Abilities.TRAIN_VIKINGFIGHTER, Time = 30 } },
                { UnitTypes.TERRAN_MEDIVAC, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 100, Gas = 100, Food = 2, Ability = Abilities.TRAIN_MEDIVAC, Time = 30 } },
                { UnitTypes.TERRAN_LIBERATOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 150, Gas = 150, Food = 3, Ability = Abilities.TRAIN_LIBERATOR, Time = 43 } },
                { UnitTypes.TERRAN_RAVEN, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 100, Gas = 200, Food = 2, Ability = Abilities.TRAIN_RAVEN, RequiresTechLab = true, Time = 34 } },
                { UnitTypes.TERRAN_BANSHEE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 150, Gas = 100, Food = 3, Ability = Abilities.TRAIN_BANSHEE, RequiresTechLab = true, Time = 43 } },
                { UnitTypes.TERRAN_BATTLECRUISER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 400, Gas = 300, Food = 6, Ability = Abilities.TRAIN_BATTLECRUISER, RequiresTechLab = true, Time = 64 } },

                { UnitTypes.ZERG_QUEEN, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_HATCHERY, UnitTypes.ZERG_LAIR, UnitTypes.ZERG_HIVE }, Minerals = 150, Food = 2, Ability = Abilities.TRAIN_QUEEN, Time = 36 } },
                { UnitTypes.ZERG_OVERLORD, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 100, Ability = Abilities.TRAIN_OVERLORD, Time = 18 } },
                { UnitTypes.ZERG_DRONE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 50, Food = 1, Ability = Abilities.TRAIN_DRONE, Time = 12 } },
                { UnitTypes.ZERG_ZERGLING, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 50, Food = 1, Ability = Abilities.TRAIN_ZERGLING, Time = 17 } },          
                { UnitTypes.ZERG_ROACH, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 75, Gas = 25, Food = 2, Ability = Abilities.TRAIN_ROACH, Time = 19 } },
                { UnitTypes.ZERG_HYDRALISK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 100, Gas = 50, Food = 2, Ability = Abilities.TRAIN_HYDRALISK, Time = 24 } },
                { UnitTypes.ZERG_INFESTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 100, Gas = 150, Food = 2, Ability = Abilities.TRAIN_INFESTOR } },
                { UnitTypes.ZERG_SWARMHOSTMP, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 100, Gas = 75, Food = 3, Ability = Abilities.TRAIN_SWARMHOST, Time = 29 } },
                { UnitTypes.ZERG_MUTALISK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 100, Gas = 100, Food = 2, Ability = Abilities.TRAIN_MUTALISK, Time = 24 } },
                { UnitTypes.ZERG_CORRUPTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 150, Gas = 100, Food = 2, Ability = Abilities.TRAIN_CORRUPTOR, Time = 29 } },
                { UnitTypes.ZERG_VIPER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 100, Gas = 75, Food = 3, Ability = Abilities.TRAIN_VIPER, Time = 29 } },
                { UnitTypes.ZERG_ULTRALISK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LARVA }, Minerals = 300, Gas = 200, Food = 6, Ability = Abilities.TRAIN_ULTRALISK, Time = 39 } },

                { UnitTypes.ZERG_BANELING, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_ZERGLING }, Minerals = 25, Gas = 25, Ability = Abilities.TRAIN_BANELING, Time = 14 } },
                { UnitTypes.ZERG_RAVAGER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_ROACH }, Minerals = 25, Gas = 75, Food = 1, Ability = Abilities.MORPH_RAVAGER, Time = 12 } },
                { UnitTypes.ZERG_LURKERMP, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_HYDRALISK }, Minerals = 50, Gas = 100, Food = 1, Ability = Abilities.MORPH_LURKER, Time = 18 } },
                { UnitTypes.ZERG_BROODLORD, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_CORRUPTOR }, Minerals = 150, Gas = 150, Food = 2, Ability = Abilities.MORPH_BROODLORD, Time = 24 } },
                { UnitTypes.ZERG_OVERSEER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_OVERLORD }, Minerals = 50, Gas = 50, Ability = Abilities.MORPH_OVERSEER, Time = 12 } },
                { UnitTypes.ZERG_OVERLORDTRANSPORT, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_OVERLORD }, Minerals = 25, Gas = 25, Ability = Abilities.MORPH_OVERLORDTRANSPORT, Time = 12 } },
            };
        }
    }
}
