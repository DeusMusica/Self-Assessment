using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Human(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

    }
}