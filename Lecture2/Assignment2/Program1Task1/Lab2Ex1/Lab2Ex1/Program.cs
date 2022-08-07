using System;

namespace Lab2Ex1
{
    class Program
    {
        static double Add(double a, double b)
        {
           return a * b; // deliberate bug! 
            //return a + b;
        }
        static void Main(string[] args)
        {
            double a = 4.5; // or use var 
            double b = 2.5;
            double answer = Add(a, b);
            // Person p = new Person();
            Console.WriteLine($"{a} + {b} = {answer}");
            /// Bug fix Console.WriteLine($"{a} * {b} = {answer}");
            Console.ReadLine(); // wait for user to press ENTER 
        }
    }
}
