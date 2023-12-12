using SC2APIProtocol;

namespace Sharky
{

    /// <summary>
    /// A service to count all units the enemy could have
    /// </summary>
    public class EnemyUnitMemoryService
    {
        
        private ActiveUnitData ActiveUnitData;
        public Dictionary<UnitTypes, int> CurrentTotalUnits;
        /// <summary>
        /// Key is the UnitType and value is a dictionary with the frame the corresponding count of total units to that time is last updated 
        /// </summary>
        public Dictionary<UnitTypes, Dictionary<uint, int>> LastTotalUnits;

        public EnemyUnitMemoryService(ActiveUnitData ActiveUnitData)
        {
            
            this.ActiveUnitData = ActiveUnitData;


            CurrentTotalUnits = new Dictionary<UnitTypes, int>();
            LastTotalUnits = new Dictionary<UnitTypes, Dictionary<uint, int>>();
        }

        public void UpdateEnemyCount(UnitTypes type,int newCount, uint frame)
        {
            if (!LastTotalUnits.ContainsKey(type))
            {
                LastTotalUnits[type] = new Dictionary<uint, int>();
            }

            LastTotalUnits[type][frame] = newCount;
            CurrentTotalUnits[type] = newCount;
        }

        public void ProcessActiveUnitData(Dictionary<ulong,UnitCalculation> currentEnemyCount, uint frame)
        {
            Dictionary<UnitTypes, int> typeCounts = new Dictionary<UnitTypes, int>();

            foreach (var enemy in currentEnemyCount.Values)
            {
                if (typeCounts.ContainsKey((UnitTypes)enemy.Unit.UnitType))
                {
                    typeCounts[(UnitTypes)enemy.Unit.UnitType] += 1;
                }
                else
                {
                    typeCounts[(UnitTypes)enemy.Unit.UnitType] = 1;
                }
            }

            foreach (var type in typeCounts.Keys)
            {
                if (!CurrentTotalUnits.ContainsKey(type) || CurrentTotalUnits[type] < typeCounts[type])
                {
                    UpdateEnemyCount(type, typeCounts[type],frame);
                } 
            }
        }
    }
}

