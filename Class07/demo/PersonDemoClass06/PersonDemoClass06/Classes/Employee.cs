using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemoClass06.Classes
{
   abstract class Employee : Person
    {
        public int Salary { get; set; }
        public string JobTitle { get; set; }


        // require the information and "send" it up to the base
        public Employee(string name):base(name)
        {

        }

        public sealed override string SleepSchedule(string name)
        {
            return "I sleep 10 - 6, because i'm \"responsible\"";
        }

    }
}
