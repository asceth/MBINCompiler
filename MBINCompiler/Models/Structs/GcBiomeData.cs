﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBiomeData : NMSTemplate
    {
        public GcMiningSubstanceData MiningSubstance1;
        public GcMiningSubstanceData MiningSubstance2;
        public GcMiningSubstanceData MiningSubstance3;
        public GcMiningSubstanceData MiningSubstance4;
        public GcPlanetWaterData Water;

        [NMSAttribute(Size = 0x80)]
        public string DiffuseMap;
        [NMSAttribute(Size = 0x80)]
        public string NormalMap;

        [NMSAttribute(Size = 10)]
        public GcTileTypeOptions[] TileTypes;

        public List<GcExternalObjectListOptions> ExternalObjectLists;

        [NMSAttribute(Size = 7, EnumValue = new string[7] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive" } )]
        public NMSBool[] WeatherOptions;

        public GcTerrainControls Terrain;
    }
}
