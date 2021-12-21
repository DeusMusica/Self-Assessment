using System;
using System.Collections.Generic;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker jim = new Worker("Jim", "Bones", 3000.00m, 2m);
            Console.WriteLine(jim.ToString());

            SortedList<Student, string> studs = new SortedList<Student, string>();

            studs.Add(new Student("Jim", "Bones", 100), "Jim Bones 1");
            studs.Add(new Student("Tim", "Jones", 10), "Jim Bones 2");
            studs.Add(new Student("Grim", "Clones", 80), "Jim Bones 3");
            studs.Add(new Student("Hymn", "Tones", 90), "Jim Bones 4");
            studs.Add(new Student("Gym", "Groans", 30), "Jim Bones 5");
            studs.Add(new Student("Shim", "Scones", 40), "Jim Bones 6");
            studs.Add(new Student("Tele", "Phones", 70), "Jim Bones 7");
            studs.Add(new Student("Slingin", "Loans", 200), "Jim Bones 8");
            studs.Add(new Student("Chisel", "Hones", 60), "Jim Bones 9");
            studs.Add(new Student("Jacob", "Moans", 50), "Jim Bones 10");

            foreach (KeyValuePair<Student, string> kvp in studs)
            {
                Console.WriteLine($"{kvp.Value} {kvp.Key.Mark}");
            }

            Worker[] workers = new Worker[10];
            workers[0] = new Worker("Jim", "Bones", 300000000000m, 300m);
            workers[1] = new Worker("Jim", "Bones", 30000000000m, 300m);
            workers[2] = new Worker("Jim", "Bones", 3000000000m, 300m);
            workers[3] = new Worker("Jim", "Bones", 300000000m, 300m);
            workers[4] = new Worker("Jim", "Bones", 30000000m, 300m);
            workers[5] = new Worker("Jim", "Bones", 3000000m, 300m);
            workers[6] = new Worker("Jim", "Bones", 300000m, 300m);
            workers[7] = new Worker("Jim", "Bones", 30000m, 300m);
            workers[8] = new Worker("Jim", "Bones", 3000m, 300m);
            workers[9] = new Worker("Jim", "Bones", 300m, 300m);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (workers[i].CalcHourlyWage() < workers[j].CalcHourlyWage())
                    {
                        Worker temp = workers[i];
                        workers[i] = workers[j];
                        workers[j] = temp;

                    }
                }
            }
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
        }
    }
}
