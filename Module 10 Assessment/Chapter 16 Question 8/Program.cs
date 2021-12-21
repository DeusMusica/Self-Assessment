using System;

namespace Chapter_16_Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int arrayLength = intArray.Length;

            int maxCount = 0;
            int index = -1;

            for (int i = 0; i < arrayLength; i++)
            {
                int count = 0;
                for (int j = 0; j < arrayLength; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }
            int majorantEquation = (arrayLength / 2) + 1;       

            if (maxCount >= majorantEquation)
            {
                Console.WriteLine("The majorant is {0}", intArray[index]);
            }
            else
                Console.WriteLine("The majorant does not exist");

        }        
    }
}
