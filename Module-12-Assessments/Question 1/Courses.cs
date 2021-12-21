using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    public class Courses
    {
        string _courseName;
        int _countOfClasses;
        int _countOfExercises;
        Teacher _teacher;

        public Courses(string courseName, int countOfClasses, int countOfExercises, Teacher teacher)
        {
            _courseName = courseName;
            _countOfClasses = countOfClasses;
            _countOfExercises = countOfExercises;
            _teacher = teacher;
        }
        public string CourseName { get; set; }
        public int CountOfClasses { get; set; }
        public int CountofExercises { get; set; }
        public Teacher Teacher { get; set; }

    }
}
