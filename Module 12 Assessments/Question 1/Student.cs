using School;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    public class Student : People
    {
        string _idNum;
        int _grades;

        public Student()
        {
            _idNum = "";
            _grades = 0;
        }
        public Student (string firstName, string lastName, string occupation, string idNum, int grades)
        {
            _idNum = idNum;
            this._grades = grades;
        }
        public string StudentID 
        {
            get
            {
                return _idNum;
            }
            set 
            {
                _idNum = value;
            }
        }
        public int Grades
        {
            get
            {
                return _grades;
            }
            set
            {
                _grades = value;
            }
        }
            
    }
}
