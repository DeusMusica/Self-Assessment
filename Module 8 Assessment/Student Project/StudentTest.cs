using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Project
{
    class StudentTest
    {
        private Student _student;
        private static Student _student1;
        private static Student _student2;
        private static Student _student3;
        private static Student _student4;


        public  Student Student
        {
            get { return _student; }
            set { _student = value; }
        }

        public static Student Student1
        {
            get { return _student1; }
            set { _student1 = value; }
        }
        public static Student Student2
        {
            get { return _student2; }
            set { _student2 = value; }
        }
        public static Student Student3
        {
            get { return _student3; }
            set { _student3 = value; }
        }
        public static Student Student4
        {
            get { return _student4; }
            set { _student4 = value; }
        }



        public StudentTest(string fullName, string course, string subject, string university, string email, string phoneNumber)
        {
            Student = new Student(fullName, course, subject, university, email, phoneNumber);
        }

        public StudentTest(string fullName, string email, string phoneNumber)
        {
            Student = new Student(fullName, email, phoneNumber);
        }

        public static void CreateSeveralStudent_Print()
        {
            Student1 = new Student("John Smith", "Main", "Women's study", "Home School University", "johnsmith@hotmail.com", "1234567890");
            Student2 = new Student("John Smith", "Main1", "Music", "Home School University", "johnsmith@hotmail.com", "1234567890");
            Student3 = new Student("John Smith", "Main2", "Woodworking", "Home School University", "johnsmith@hotmail.com", "1234567890");
            Student4 = new Student("John Smith", "Main3", "Computer Science", "Home School University", "johnsmith@hotmail.com", "1234567890");
        }

        public override string ToString()
        {
            Console.WriteLine(Student);
            return base.ToString();
        }
    }
}
