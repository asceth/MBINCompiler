﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcTechnologyRequirement : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string ID;

        public GcInventoryType InventoryType;
        public int Amount;
    }
}
