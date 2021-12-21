using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, List<decimal>> Morty = new Dictionary<string, List<decimal>>()
            {
                { "Morty", new List<decimal>{ } },
                { "Homework", new List<decimal> { 80.5m, 90m, 53.4m} },
                { "quizzes", new List<decimal> { 80.5m, 90m, 53.4m} },
                { "tests", new List<decimal> { 80.5m, 90m, 53.4m} }
            };
            IDictionary<string, List<decimal>> Charlie = new Dictionary<string, List<decimal>>()
            {
                { "Charlie", new List<decimal>{ } },
                { "Homework", new List<decimal> { 80.5m, 90m, 53.4m} },
                { "quizzes", new List<decimal> { 80.5m, 90m, 53.4m} },
                { "tests", new List<decimal> { 80.5m, 90m, 53.4m} }
            };
            IDictionary<string, List<decimal>> Opie = new Dictionary<string, List<decimal>>()
            {
                { "Opie", new List<decimal>{ } },
                { "Homework", new List<decimal> { 80.5m, 90m, 53.4m} },
                { "quizzes", new List<decimal> { 80.5m, 90m, 53.4m} },
                { "tests", new List<decimal> { 80.5m, 90m, 53.4m} }
            };


            List<IDictionary<string, List<decimal>>> Student = new List<IDictionary<string, List<decimal>>>();

            Student.Add(Morty);
            Student.Add(Charlie);
            Student.Add(Opie);
            //printing info
            foreach (IDictionary<string, List<decimal>> items in Student)
            {
                foreach (KeyValuePair<string, List<decimal>> item in items)
                {
                    PrintStudentInfo(item);
                }
            }
            //calculating average
            foreach (IDictionary<string, List<decimal>> Name in Student)
            {
                CalculateAssignmentAverage(Name, Morty["quizzes"]);
            }
        }

        public static void PrintStudentInfo(KeyValuePair<string, List<decimal>> items)
        {
            if (items.Value == default)
            {
                Console.Write(items.Key);
            }
            else
            {
                Console.WriteLine($"{items.Key} ");
            }

            //Console.WriteLine($"Score: ");
            foreach (decimal score in items.Value)
            {
                Console.WriteLine(score);

            }
            Console.WriteLine();

        }

        public static void CalculateAssignmentAverage(KeyValuePair<string, List<decimal>> name, assignment)
        {
            if (items.Value == default)
            {
                Console.Write(items.Key);
            }
            else
            {
                Console.WriteLine($"{items.Key} ");
            }

            //Console.WriteLine($"Score: ");
            
            //List<decimal> scores = New List<decimal>(){ items.value};

            
            Console.WriteLine();
        }
    }
}
