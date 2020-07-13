using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemoClass06.Classes
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string FavoriteColor { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Walking()
        {
            Console.WriteLine("I am walking");
        }

        public void Talking()
        {
            Console.WriteLine("I am talking");
        }
    }
}
