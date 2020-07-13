using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemoClass06.Classes
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string JobTitle { get; set; }


        // require the information and "send" it up to the base
        public Employee(string name):base(name)
        {

        }

    }
}
