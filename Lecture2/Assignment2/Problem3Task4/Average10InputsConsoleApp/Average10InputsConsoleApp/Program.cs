using System;
namespace Average10InputsConsoleApp
{
	class Program
	{ 	public static double[] NumArray = new double[10];
		public static double TakeInputsFromUser()
		{	Console.WriteLine("Please input 10 numbers. Press 'ENTER' after each number.");
			for (int i = 0; i < 10; i++)
			{NumArray[i] = Convert.ToDouble(Console.ReadLine());
			}
		   /* for (int i = 0; i < NumArray.Length; i++)
			{
				Console.WriteLine(NumArray[i]);
			}
		   */
			return NumArray[0];
		}
		public static double AverageOf10Numbers(double[] NumArray)
		{	double avg, sum = 0;
			for (int i = 0; i < 10; i++)
			{ sum = NumArray[i] + sum;
			}
			avg = sum / NumArray.Length;
			// Console.WriteLine(avg);
			return avg;
		}
		static public void PrintAvg(double[] Array, double Value)
        {	for (int i = 0; i < 10; i++)
            { Console.WriteLine("Array Element[" + i + "]=" + Array[i]);
			}
			Console.WriteLine($"The average value of ten numbers is " + Value);
		}
		static void Main(string[] args)
		{	Console.WriteLine("By - Shyed Shahriar Housaini MCSE 07905536");
			Console.WriteLine("Problem 3 Task 4: Understand the following program(Program3) and run it as ConsoleAPP(ASP.Core)  \n " +
				"Problem3: Take 10 inputs from console and print their average in console. \n" +
				" • You should use separate function to take input and find average. \n " +
				" • Main() will call those functions and print the average.");
			Console.WriteLine("To calculate average");
			TakeInputsFromUser();
  			double Val = AverageOf10Numbers(NumArray);
			//Console.WriteLine("The average value of ten numbers is " + Val);
			PrintAvg(NumArray,Val); // Printing the array by passing the array and average Value
			Console.ReadKey();
		}
	}
}
