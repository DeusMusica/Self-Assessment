using System;

namespace Student_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentTest fullStudent = new StudentTest("John Smith", "Main", "Women's study", "Home School University", "johnsmith@hotmail.com", "1234567890");
            //StudentTest halfStudetn = new StudentTest("John Smith", "johnsmith@hotmail.com", "1234567890");

            //Console.WriteLine(fullStudent);
            //Console.WriteLine(halfStudetn);

            //Console.WriteLine("Student count is " + Student.studentNumber);
            StudentTest.CreateSeveralStudent_Print();
            Console.WriteLine(StudentTest.Student1);
            Console.WriteLine(StudentTest.Student2);
            Console.WriteLine(StudentTest.Student3);
            Console.WriteLine(StudentTest.Student4);
        }


    }
}
