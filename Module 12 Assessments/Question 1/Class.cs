using School;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    public class Class
    {
        string _className;
        Student _student;
        Teacher _teacher;
        
        public Class(string className, Student student, Teacher Teacher)
        {
            this._className = className;
            _student = student;
            _teacher = Teacher;
        }

        public string ClassName
        {
            get
            {
                return _className;
            }
            set
            {
                _className = value;
            }
        }
        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
            }
        }
        public Teacher Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                _teacher = value;
            }
        }
    }
}
