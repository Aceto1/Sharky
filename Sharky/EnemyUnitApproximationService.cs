namespace Sharky
{
    public class EnemyUnitApproximationService
    {
        public Dictionary<UnitTypes, Dictionary<uint, int>> LastTotalUnits { get; }

        private SharkyOptions SharkyOptions;

        public EnemyUnitApproximationService(SharkyOptions sharkyOptions)
        {
            LastTotalUnits = new Dictionary<UnitTypes, Dictionary<uint, int>>();

            SharkyOptions = sharkyOptions;
        }

        public void UpdateEnemyApproximation(UnitTypes type, Dictionary<uint, int> data)
        {
            Dictionary<uint, int> newData = new Dictionary<uint, int>();

            if (type == UnitTypes.TERRAN_SCV)
            {
                var frames = data.Keys.OrderBy(u => u);

                for (int i = 0; i < frames.Count(); i++)
                {
                    uint currentFrame = frames.ElementAt(i);
                    int currentData = data[currentFrame];

                    if (i < data.Count - 1)
                    {
                        uint nextFrame = frames.ElementAt(i + 1);
                        int nextData = data[nextFrame];

                        int dataDifference = nextData - currentData;
                        uint frameDifference = nextFrame - currentFrame;

                        for (int s = 0; s < dataDifference; s++)
                        {
                            uint newFrame =
                                currentFrame
                                + (uint)Math.Floor((double)frameDifference / dataDifference * s);
                            newData[newFrame] = currentData + s;
                        }
                    }
                    else
                    {
                        int dataDifference = 90 - currentData;

                        for (int s = 0; s < dataDifference; s++)
                        {
                            // 1 scv in 12 seconds
                            uint newFrame =
                                currentFrame
                                + (uint)Math.Floor(s * 12 * SharkyOptions.FramesPerSecond);

                            newData[newFrame] = currentData + s;
                        }
                    }
                }
            }

            LastTotalUnits[type] = newData;
        }
    }
}
