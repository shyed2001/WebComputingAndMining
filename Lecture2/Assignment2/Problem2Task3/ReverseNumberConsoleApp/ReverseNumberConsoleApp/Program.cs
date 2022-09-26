
/*
 * 
 * * Task3: Use the console to take input to a C# program and display contents to the console.
Problem2:
Read a three digit integer input from the console, and print the reverse of that number in the
console.
• You can call a reverse() method from Main() and pass the integer values.
• Reverse() method will return the reverse value to Main().
• Main() will catch and print the value.
 * */
using System;
namespace ReverseNumberConsoleApp
{
    class Program
     {
        static int Reverse(int number)
        {
            /* double number, reverse = 0, remainder;
              n = double.Parse(Console.ReadLine());
              n = Convert.ToDouble(Console.ReadLine());
            */
            int reminder, reverse = 0;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                //number = number / 10;
                number /= 10;
            }
            return reverse;  
        }

        static void Main(string[] args)
        {
            string multilineProblem = @"Task3: Use the console to take input to a C# program and display contents to the console.
Problem2:
Read a three digit integer input from the console, and print the reverse of that number in the
console.
• You can call a reverse() method from Main() and pass the integer values.
• Reverse() method will return the reverse value to Main().
• Main() will catch and print the value.";

            Console.WriteLine(multilineProblem);

            Console.Write("Enter an integer number to reverse: ");
            int number = int.Parse(Console.ReadLine());
            int reverse = Reverse(number);
            Console.Write("Reversed Number: " + reverse);
            Console.ReadLine();
            Console.Write("-Shyed Shahriar Housaini, MCSE 07905536");
        }
    }
}
