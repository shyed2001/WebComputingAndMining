/*
 * " Task2: Class library(.dll) creation, reference as assembly, and import as namespace \n " +
                "a) Create two namespaces in two different projects and import them into the third project and use the imported namespaces methods. \n " +
                "b) Apply your knowledge into program1 and use Add methods from separate.dll.Explain the code reusability."
 * 
 * 
 * */
using System;
using SumReusableClassLibrary;
using SubtractReusableClassLibrary;


namespace DoubleLibraryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("By - Shyed Shahriar Housaini MCSE 07905536");
            Console.WriteLine(" Task2: Class library(.dll) creation, reference as assembly, and import as namespace \n " +
                "a) Create two namespaces in two different projects and import them into the third project and use the imported namespaces methods. \n " +
                "b) Apply your knowledge into program1 and use Add methods from separate.dll.Explain the code reusability. \n \n ");
            
            Console.WriteLine("Please enter the first number - ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number - ");
            int secondNumber = int.Parse(Console.ReadLine());

            ClassSum programSum = new ClassSum();
            var SumResult = programSum.SumInt(firstNumber,secondNumber);

            ClassSubtract programSubtract = new ClassSubtract();
            var SubtractResult = programSubtract.SubtractInt(firstNumber, secondNumber);

           Console.WriteLine(" = Result of Subtraction = " + SubtractResult);

            Console.WriteLine("Result of Addition = " + SumResult);

            Console.ReadLine();
            Console.Write("Shyed Shahriar Housaini, MCSE 07905536");
        }
    }
}
