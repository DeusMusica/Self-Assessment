using System;

namespace Chapter_12_Question_8
{
    class Program
    {
        static void ReadNumber(int start, int end)
        {
            if (start < end)
            {
                if (start < 1 || end > 100)
                {
                    Console.Write("Out of Range");
                    
                }
            }
            else
            {
                Console.WriteLine("Out of Range");
            }
            int newNum, prevNum;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine("Enter a number within the range");
                    newNum = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        if (newNum < start || newNum > end)
                        {
                            Console.WriteLine("Not within Range!");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Not within Range!");
                }
            }
        static void Main(string[] args)
        {
            try
            {
                int convertedStartInput = 0;
                int convertedEndInput = 0;

                Console.Write("Enter Start Number: ");
                string startInput = Console.ReadLine();
                convertedStartInput = Convert.ToInt32(startInput);

                Console.Write("Enter End Number: ");
                string endInput = Console.ReadLine();                
                convertedEndInput = Convert.ToInt32(endInput);

                ReadNumber(convertedStartInput, convertedEndInput);
             
            }
            catch (Exception fe)
            {
                Console.WriteLine("Invalid Number!", fe);
            }

            
            }
            
            
        }
    }
}
