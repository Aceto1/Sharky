namespace Sharky
{
    /// <summary>
    /// A service to count all units the enemy could have
    /// </summary>
    public class EnemyUnitMemoryService
    {
        private ActiveUnitData activeUnitData;
        public Dictionary<UnitTypes, int> CurrentTotalUnits { get; }

        /// <summary>
        /// Key is the UnitType and value is a dictionary with the frame the corresponding count of total units to that time is last updated
        /// </summary>
        public Dictionary<UnitTypes, Dictionary<uint, int>> LastTotalUnits { get; }

        public EnemyUnitMemoryService(ActiveUnitData activeUnitData)
        {
            this.activeUnitData = activeUnitData;

            CurrentTotalUnits = new Dictionary<UnitTypes, int>();
            LastTotalUnits = new Dictionary<UnitTypes, Dictionary<uint, int>>();

            UpdateEnemyCount(UnitTypes.TERRAN_SCV, 12, 1);
            UpdateEnemyCount(UnitTypes.TERRAN_COMMANDCENTER, 12, 1);
        }

        public void UpdateEnemyCount(UnitTypes type, int newCount, uint frame)
        {
            if (!LastTotalUnits.TryGetValue(type, out var value))
            {
                value = new();
                LastTotalUnits[type] = value;
            }

            value[frame] = newCount;
            CurrentTotalUnits[type] = newCount;
        }

        public void ProcessActiveUnitData(Dictionary<ulong, UnitCalculation> currentEnemyCount, uint frame)
        {
            var typeCounts = new Dictionary<UnitTypes, int>();

            foreach (var enemy in currentEnemyCount.Values)
            {
                if (typeCounts.ContainsKey((UnitTypes)enemy.Unit.UnitType))
                {
                    typeCounts[(UnitTypes)enemy.Unit.UnitType]++;
                }
                else
                {
                    typeCounts[(UnitTypes)enemy.Unit.UnitType] = 1;
                }
            }

            foreach (var type in typeCounts.Keys)
            {
                if (!CurrentTotalUnits.TryGetValue(type, out var value) || value < typeCounts[type])
                {
                    UpdateEnemyCount(type, typeCounts[type], frame);
                }
            }
        }
    }
}
