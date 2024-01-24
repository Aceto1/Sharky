namespace Sharky
{
    /// <summary>
    /// A for tracking the exploration or visibility state of the map
    /// </summary>
    public class MapMemoryService
    {
        /// <summary>
        /// Key is the frame, value is the count mapcells, that are explored, but not visible
        /// </summary>
        public Dictionary<uint, float> lastExploredPoints { get; set; }
        /// <summary>
        /// Key is the frame, value is the count mapcells, that are visible and explored
        /// </summary>
        public Dictionary<uint, float> lastVisiblePoints { get; set; }

        /// <summary>
        /// Key is the frame, value is the count mapcells, that are not explored
        /// </summary>
        public Dictionary<uint, float> lastUnexploredPoints { get; set; }

        private uint currentFrame;

        private MapDataService MapDataService;

        public MapMemoryService(MapDataService mapDataService)
        {
            lastUnexploredPoints = new Dictionary<uint, float>();
            lastVisiblePoints = new Dictionary<uint, float>();
            lastExploredPoints = new Dictionary<uint, float>();

            MapDataService = mapDataService;
        }

        public void ProcessVisibility(int visibility, uint frame) {
            if (visibility == 0) {
                if (lastUnexploredPoints.ContainsKey(frame)) {
                    lastUnexploredPoints[frame]++;
                } else {
                    lastUnexploredPoints[frame] = 1;
                }
            } else {
                if (lastExploredPoints.ContainsKey(frame)) {
                    lastExploredPoints[frame] = lastExploredPoints.GetValueOrDefault(frame) + 1;
                } else {
                    lastExploredPoints[frame] = 1;
                }

                if (visibility == 2) {
                    if (lastVisiblePoints.ContainsKey(frame)) {
                        lastVisiblePoints[frame] = lastVisiblePoints.GetValueOrDefault(frame) + 1;
                    } else {
                        lastVisiblePoints[frame] = 1;
                    }
                } 
            }

            currentFrame = frame;

            
        }

        public float GetCurrentExploredPercentage() {
            return GetExploredPercentage(currentFrame);
        }

        public float GetCurrentUnexploredPercentage() {
            return GetUnexploredPercentage(currentFrame);
        }

        public float GetCurrentVisiblePercentage() {
            return GetVisiblePercentage(currentFrame);        
        }


        public float GetExploredPercentage(uint frame) {
            frame = GetLastUpdate(frame);

            return lastExploredPoints.GetValueOrDefault(frame, 0) / MapDataService.MapData.MapHeight / MapDataService.MapData.MapWidth;
        }

        public float GetUnexploredPercentage(uint frame) {
            frame = GetLastUpdate(frame);

            // Console.WriteLine("LastUnexplored: " + lastUnexploredPoints.GetValueOrDefault(frame, 0) + " Contains frame " +  frame + ": " + lastUnexploredPoints.ContainsKey(frame));
            return lastUnexploredPoints.GetValueOrDefault(frame, 0) / MapDataService.MapData.MapHeight / MapDataService.MapData.MapWidth;
        }

        public float GetVisiblePercentage(uint frame) {
            frame = GetLastUpdate(frame);

            return lastVisiblePoints.GetValueOrDefault(frame, 0) / MapDataService.MapData.MapHeight / MapDataService.MapData.MapWidth;
        }

        public uint GetLastUpdate(uint frame) {
            return frame - (frame % 5);
        }
    }
}
