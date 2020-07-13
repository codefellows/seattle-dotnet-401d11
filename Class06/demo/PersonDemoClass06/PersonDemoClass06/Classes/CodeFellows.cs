using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemoClass06.Classes
{
    class CodeFellows : Student
    {
        public string TechStack { get; set; }

        public CodeFellows(string name) : base(name)
        {

        }

        public void Celebrate()
        {
            Console.WriteLine(".NET ROCKS!");
        }
    }
}
