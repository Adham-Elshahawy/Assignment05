﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string Fname { get; set; }

        public string Lname { get; set; }

        public Department Department { get; set; }

    }
    internal class Department 
    {
        public int code { get; set; }

        public string Name { get; set; }

        
    }
}
 