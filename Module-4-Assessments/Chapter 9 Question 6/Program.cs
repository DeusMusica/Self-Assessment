using System;

namespace Chapter_9_Question_6
{
    class Program
    {
        static int number = int.MinValue;

        static void CompareNumbers(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    number = arr[i];
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter array lenth: ");
            int lenght = int.Parse(Console.ReadLine());

            int[] arr = new int[lenght];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            CompareNumbers(arr);

            if (number == int.MinValue)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("{0} is bigger than it's neighbors", number);
            }
        }
    }
}
