using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class TomCat : Animal
    {
        public TomCat(int age, string name, bool male) : base(age, name, male)
        { }

        public override string MakeSound()
        {
            return "WeeeeWoooo!!!";
        }
    }
}