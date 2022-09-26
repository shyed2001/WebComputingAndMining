using System;
[assembly: CLSCompliant(true)]
namespace SubtractReusableClassLibrary
{
    public class ClassSubtract
    {
        public int SubtractInt(int n1, int n2)
        {
            Console.Write($"{n1} - {n2}");
            return n1 - n2;
        }
        public float SubtractFloat(float n1, float n2)
        {
            Console.WriteLine($"{n1} - {n2}");
            return n1 - n2;
        }
        public double SubtractDouble(double n1, double n2)
        {
            Console.WriteLine($"{n1} - {n2}");
            return n1 - n2;
        }
        public double SubtractLong(long n1, long n2)
        {
            Console.WriteLine($"{n1} - {n2}");
            return n1 - n2;
        }
    }
}
