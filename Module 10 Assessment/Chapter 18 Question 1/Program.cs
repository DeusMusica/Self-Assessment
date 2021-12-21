using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_18_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, int> numOfOccurences = new Dictionary<int, int>();
            int[] intArray = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int arrayLength = intArray.Length;


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
                if (!numOfOccurences.ContainsKey(intArray[i]))
                {
                    numOfOccurences.Add(intArray[i], count);
                }
            }
            foreach (KeyValuePair<int, int> pair in numOfOccurences)
            {
                Console.WriteLine("|" + pair.Key + "->" + pair.Value + "times |");
            }
        }
    }
}
