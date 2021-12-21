using School;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    public class Teacher : People
    {
        string _id;
        string _setOfCourses;

        public Teacher(string firstName, string lastName, string occupation, string id)
        {
            this._id = id;
        }
        public string TeacherID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Courses
        {
            get
            {
                return _setOfCourses;
            }
            set
            {
                _setOfCourses = value;
            }
        }
    }
    
}
