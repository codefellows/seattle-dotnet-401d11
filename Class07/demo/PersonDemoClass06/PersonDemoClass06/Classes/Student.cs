using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemoClass06.Classes
{
    // Derived Class : Base Class
    class Student : Person
    {
        public decimal GPA { get; set; }
        public List<string> CourseSchedule { get; set; }

        public Student(string name):base(name)
        {
            
        }
        public void GetGrades()
        {
            Console.WriteLine("I am getting the grades");
        }

        public override string SleepSchedule(string name)
        {
            return "I don't sleep. I do all the things";
        }
    }
}
