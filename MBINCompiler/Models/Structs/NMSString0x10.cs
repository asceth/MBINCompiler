using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class NMSString0x10 : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Value;
    }
}