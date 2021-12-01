using System;
using System.Threading.Channels;
using Microsoft.VisualBasic.CompilerServices;

namespace Module6
{
	class Program
	{
		static void Main(string[] args)
		{
			int valueOne = 0;
			int valueTwo = 0;
			string userChoice = "";
			try
			{
				Console.WriteLine("Select an operation.\n1) AddValues\n2) SubtractValues\n3) MultiplyValues\n4) DivideValues\n5) RemainderValues\n");
				userChoice = Console.ReadLine();
				if (int.Parse(userChoice) < 1 || int.Parse(userChoice) > 5)
                {
					throw new ArgumentOutOfRangeException();
                }
			}
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Not A Valid Menu Option");

				
            }
			try
			{
				Console.WriteLine("Enter a number.");
				valueOne = int.Parse(Console.ReadLine());
				try
				{
					Console.WriteLine("Enter another number.");
					valueTwo = int.Parse(Console.ReadLine());
				}
				catch (FormatException fe)
				{
					Console.WriteLine("The input is not a number");
					userChoice = "0";
				}
			}
			catch (FormatException fe)
			{
				Console.WriteLine("The input is not a number");
				userChoice = "0";
			}

			switch (userChoice)
			{
				case "1":
					Console.WriteLine($"Result={AddValues(valueOne, valueTwo)}");
					break;
				case "2":
					Console.WriteLine($"Result={SubtractValues(valueOne, valueTwo)}");
					break;
				case "3":
					Console.WriteLine($"Result={MultiplyValues(valueOne, valueTwo)}");
					break;
				case "4":
					Console.WriteLine($"Result={DivideValues(valueOne, valueTwo)}");
					break;
				case "5":
					Console.WriteLine($"Result={RemainderValues(valueOne, valueTwo)}");
					break;
				default:
                    Console.WriteLine("Invalid Menu Choice");
					break;
			}
		}
		static int AddValues(int valueOne, int valueTwo)
		{

			return valueOne + valueTwo;
		}

		static int SubtractValues(int valueOne, int valueTwo)
		{

			return valueOne - valueTwo;
		}

		static int MultiplyValues(int valueOne, int valueTwo)
		{

			return valueOne * valueTwo;
		}

		static int DivideValues(int valueOne, int valueTwo)
		{
			try
			{
				return valueOne / valueTwo;
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Can't divide by zero");
				return 0;

			}
		}

		static int RemainderValues(int valueOne, int valueTwo)
		{
			try
			{
				return valueOne % valueTwo;
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Can't divide by zero");
				return 0;

			}
		}
	}
}
