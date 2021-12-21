using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Project
{
    public class Student
    {
        private string _fullName;
        private string _course;
        private string _subject;
        private string _university;
        private string _email;
        private string _phoneNumber;
        public static int studentNumber = 0;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string University
        {
            get { return _university; }
            set { _university = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        

        public Student(string fullName, string course, string subject, string university, string email, string phoneNumber)
        {
            FullName = fullName;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phoneNumber;
            studentNumber += 1;
        }

        public Student(string fullName, string email, string phoneNumber)
        {
            FullName = fullName;
            Course = null;
            Subject = null;
            University = null;
            Email = email;
            PhoneNumber = phoneNumber;
            studentNumber += 1;
        }

        public Student()
        {
            FullName = null;
            Course = null;
            Subject = null;
            University = null;
            Email = null;
            PhoneNumber = null;            
        }

        public override string ToString()
        {
            return string.Format("Student information:\n Name:{0}\n E-mail{1}\n Phone:{2}\n University:{3}\n Subject:{4}\n Course:{5}",
                FullName, Email, PhoneNumber, University, Subject, Course);
        }
    }
}
