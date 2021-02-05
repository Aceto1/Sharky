﻿using SC2APIProtocol;
using System.Collections.Generic;

namespace Sharky.Builds
{
    public interface IBuildingBuilder
    {
        List<Action> BuildBuilding(MacroData macroData, UnitTypes unitType, BuildingTypeData unitData, Point2D generalLocation = null, bool ignoreMineralProximity = false, float maxDistance = 50, List<UnitCommander> workerPool = null);
        List<Action> BuildAddOn(MacroData macroData, TrainingTypeData unitData, Point2D location = null, float maxDistance = 50);
        List<Action> BuildGas(MacroData macroData, BuildingTypeData unitData, Unit geyser);
        Point2D GetReferenceLocation(Point2D buildLocation);
    }
}
