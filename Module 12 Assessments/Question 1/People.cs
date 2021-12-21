using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class People
    {
        private string _firstName;
        private string _lastName;
        private string _occupation;

        public People()
        {
            _firstName = _lastName = _occupation = "";
        }

        public People (string firstName, string lastName, string occupation)
        {
            _firstName = firstName;
            _lastName = lastName;
            _occupation = occupation;
        }

        public string FirstName
        {
            get 
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }

        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }
        public string Occupation
        {
            get
            {
                return _occupation;
            }
            set
            {
                _occupation = value;
            }

        }

    }
}
