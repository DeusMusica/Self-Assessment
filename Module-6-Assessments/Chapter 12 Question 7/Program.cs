using System;

namespace Chapter_12_Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int n = -1;
            bool invalidNumber = false;

            try
            {
                n = Convert.ToInt32(input);
                Console.WriteLine(Math.Sqrt(n));
            }
            catch 
            {
                Console.WriteLine("Invalid Number!");
                //invalidNumber = true;
            }
            //finally
            //{
            //    if (n < 0)
            //    {
            //        if (!invalidNumber) Console.WriteLine("Invalid Number!");
            //    }
            //    else Console.WriteLine(Math.Sqrt(n));
            //}

            Console.WriteLine("Good Bye");
        }
    }
}
