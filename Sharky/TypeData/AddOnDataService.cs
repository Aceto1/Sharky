namespace Sharky.TypeData
{
    public class AddOnDataService
    {
        public Dictionary<UnitTypes, TrainingTypeData> AddOnData()
        {
            return new Dictionary<UnitTypes, TrainingTypeData>
            {
                { UnitTypes.TERRAN_BARRACKSTECHLAB, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 50, Gas = 25, Ability = Abilities.BUILD_TECHLAB_BARRACKS, Time = 36 } },
                { UnitTypes.TERRAN_BARRACKSREACTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKS }, Minerals = 50, Gas = 50, Ability = Abilities.BUILD_REACTOR_BARRACKS, Time = 18 } },
                { UnitTypes.TERRAN_FACTORYTECHLAB, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 50, Gas = 25, Ability = Abilities.BUILD_TECHLAB_FACTORY, Time = 36 } },
                { UnitTypes.TERRAN_FACTORYREACTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORY }, Minerals = 50, Gas = 50, Ability = Abilities.BUILD_REACTOR_FACTORY, Time = 18 } },
                { UnitTypes.TERRAN_STARPORTTECHLAB, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 50, Gas = 25, Ability = Abilities.BUILD_TECHLAB_STARPORT, Time = 36 } },
                { UnitTypes.TERRAN_STARPORTREACTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORT }, Minerals = 50, Gas = 50, Ability = Abilities.BUILD_REACTOR_STARPORT , Time = 18 } }
            };
        }
    }
}
