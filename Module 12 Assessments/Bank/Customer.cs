﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Customer
    {
        public string Name { get; set; }
        public bool IsCompany { get; set; }
        public Customer(string name, bool isCompany)
        {
            Name = name;
            IsCompany = isCompany;
        }
    }
}