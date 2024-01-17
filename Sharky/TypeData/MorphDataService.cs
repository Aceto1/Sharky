namespace Sharky.TypeData
{
    public class MorphDataService
    {
        public Dictionary<UnitTypes, TrainingTypeData> MorphData()
        {
            return new Dictionary<UnitTypes, TrainingTypeData>
            {
                { UnitTypes.TERRAN_PLANETARYFORTRESS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_COMMANDCENTER }, Minerals = 150, Gas = 150, Ability = Abilities.MORPH_PLANETARYFORTRESS, Time = 36 } },
                { UnitTypes.TERRAN_ORBITALCOMMAND, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_COMMANDCENTER }, Minerals = 150, Ability = Abilities.MORPH_ORBITALCOMMAND, Time = 25 } },

                { UnitTypes.ZERG_LAIR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_HATCHERY }, Minerals = 150, Gas = 100, Ability = Abilities.MORPH_LAIR, Time = 57 } },
                { UnitTypes.ZERG_HIVE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LAIR }, Minerals = 200, Gas = 150, Ability = Abilities.MORPH_HIVE, Time = 71 } },
                { UnitTypes.ZERG_GREATERSPIRE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPIRE }, Minerals = 100, Gas = 150, Ability = Abilities.MORPH_GREATERSPIRE, Time = 71 } },
            };
        }
    }
}
