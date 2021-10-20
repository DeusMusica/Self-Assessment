using System;

namespace Chapter_9_Question_2
{
    class Program
    {
        static int GetMax(int methodInput1, int methodInput2)
        {
            int output1 = Math.Max(methodInput1, methodInput2);
            return output1;
        }

        static int GetUserInput()
        {
            int userInput;
            bool inputRes = int.TryParse(Console.ReadLine(), out userInput);
            while (!inputRes)
            {

                Console.Write("No, give me a real integer: ");
                inputRes = int.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }

          
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter three integars: ");
            int input1 = GetUserInput();
            int input2 = GetUserInput();
            int input3 = GetUserInput();

            int result1 = GetMax(input1, input2);
            int printResult = GetMax(input3, result1);

            Console.WriteLine("The max number is " + printResult);


        }
    }
}
