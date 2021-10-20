using System;

namespace Chapter_11_Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.Write("Enter sequence of numbers: ");
            string userInput = Console.ReadLine();
            string[] splitNumbers = userInput.Split(' ');

            for (int i = 0; i < splitNumbers.Length; i++)
            {
                result += Convert.ToInt32(splitNumbers[i]);
            }

            Console.WriteLine("Result is: {0}", result);
        }
    }
}
