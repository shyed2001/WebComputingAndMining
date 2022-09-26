using System;
namespace ConsoleAppStringArraySwitchCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("By - Shyed Shahriar Housaini MCSE 07905536");
            Console.WriteLine(" Task4: Understand the following program(Program3) and run it as ConsoleAPP(ASP.Core)  \n " + 
                " Problem3: Write a program so that if the user gives input ‘d’ or ‘D’; ‘k’ or ‘K’ and ‘s’ or ‘S’ the program will print Dhaka, Khulna, and Sylhet respectively. \n" + 
                " • You need to use a switch statement. \n" + 
                " • Dhaka, Khulna, and Sylhet will be stored in a string array. ");
            string PlaceName;
            //Reading from user
            Console.WriteLine("Please Enter ‘d’ or ‘D’; ‘k’ or ‘K’ and ‘s’ or 'S’ for place selection");
            PlaceName = Console.ReadLine();
            string[] Array = new string[] { "Dhaka", "Khulna", "Sylhet" };
            switch (PlaceName)
            {
                case "d":
                    Console.WriteLine(Array[0]);
                break;
                case "D":
                    Console.WriteLine(Array[0]);
                break;
                case "k":
                    Console.WriteLine(Array[1]);
                break;
                case "K":
                    Console.WriteLine(Array[1]);
                break;
                case "s":
                    Console.WriteLine(Array[2]);
                break;
                case "S":
                    Console.WriteLine(Array[2]);
                break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
              Console.ReadLine();
            Console.Write("-Shyed Shahriar Housaini, MCSE 07905536");
        }
    }
   
}
