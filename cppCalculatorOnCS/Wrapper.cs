using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace cppCalculatorOnCS
{
    public static class Wrapper
    {
        #region dllImports
        private const string _dllImportPath = @"CSCalculatorOnCPPDLL.dll";
        [DllImport(_dllImportPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Initialize(int x);

        [DllImport(_dllImportPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(IntPtr t, int y);

        [DllImport(_dllImportPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Multiply(IntPtr t, int y);

        [DllImport(_dllImportPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Subtract(IntPtr t, int y);

        [DllImport(_dllImportPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Divide(IntPtr t, int y);
        #endregion
    }
}
