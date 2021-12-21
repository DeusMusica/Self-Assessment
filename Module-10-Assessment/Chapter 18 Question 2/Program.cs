using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter_18_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            List<int> intList = new List<int>();
            int arrayLength = intArray.Length;
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    int count = 0;

                    for (int j = 0; j < arrayLength; j++)
                    {
                        if (intArray[i] == intArray[j])
                            count++;
                    }
                    if (count % 2 == 0)
                    {
                        intList.Add(intArray[i]);
                    }                    
                }
            }
            foreach (int item in intList)
            {
                Console.Write(item + ", ");

            }
            //Can I convert to an array or make an array and predefine the length?
        }
    }
}
