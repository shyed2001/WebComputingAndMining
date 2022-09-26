using System;
[assembly: CLSCompliant(true)]
namespace SumReusableClassLibrary
{
    public class ClassSum
    {
        public int SumInt(int n1, int n2)
        {
            return n1 + n2;
        }
        public float SumFloat(float n1, float n2)
        {
            return n1 + n2;
        }
        public double SumDouble(double n1, double n2)
        {
            return n1 + n2;
        }
        public double SumLong(long n1, long n2)
        {
            return n1 + n2;
        }
    }
}