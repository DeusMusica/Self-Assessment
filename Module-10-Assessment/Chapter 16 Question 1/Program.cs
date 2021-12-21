using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_16_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>(); 
            bool go = false;
            while (go == false)
            {
                string userInput;
                int parsedInput;
                Console.WriteLine("Please enter a postive number (Press enter when done): ");
                userInput = Console.ReadLine();
                
                if (userInput == "")
                {
                    go = true;
                    break;
                }
                else
                {
                    parsedInput = int.Parse(userInput);
                    intList.Add(parsedInput);                    
                }
                    

            }
            int total = intList.Sum();
            int listLength = intList.Count;
            int averageResult = total / listLength; 
            Console.WriteLine("Sum is {0}", total);
            Console.WriteLine("Average is {0}", averageResult);
            
        }
    }
}
