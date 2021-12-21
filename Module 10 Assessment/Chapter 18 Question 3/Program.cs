using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chapter_18_Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> numOfOccurences = new Dictionary<string, int>();
            string filepath = "C:/Users/john.galloway/source/repos/Module 10 Assessment/thistext.txt";            
            string readText = File.ReadAllText(filepath);
            //Console.WriteLine(readText);

            StringBuilder sb = new StringBuilder();
            foreach (char c in readText)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }

            string builtString = sb.ToString();
            //Console.WriteLine(builtString);
            //
            builtString = builtString.ToLower();
            //Console.WriteLine(builtString);

            int stringLength = builtString.Length;
            List<string> stringList = new List<string>();

            foreach (string word in builtString.Split(' '))
            {
                if (word.Trim() != "")
                {
                    stringList.Add(word); 
                }
            }

            foreach (string wordA in stringList)
            {
                int count = 0;
                foreach (string wordB in stringList)
                {
                    if (wordA == wordB)
                    {
                        count++;
                    }
                }
                if (!numOfOccurences.ContainsKey(wordA))
                {
                    numOfOccurences.Add(wordA, count);
                }
                
            }
            foreach (KeyValuePair<string, int> pair in numOfOccurences)
            {
                Console.WriteLine(pair.Key + "->" + pair.Value);
            }
        }
    }
}
