/// <summary>Cross language , cross library - Shyed Shahriar Housaini , MCSE 07905536</summary>
using System;
[assembly : CLSCompliant(true)]
namespace ClassLibraryCrossPlatformAPP
{
    public class Class
    {
        public int Sum(int N1, int N2)
        {
            return N1 + N2;
        }
        public int Sub(int N1, int N2)
        {
            return N1 - N2;
        }
        public int Multi(int N1, int N2)
        {
            return N1 * N2;
        }
    }
}
