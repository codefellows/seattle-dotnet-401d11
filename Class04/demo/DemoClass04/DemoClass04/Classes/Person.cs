using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DemoClass04.Classes
{
    class Person
    {
        // Class is a template
        // Class contains all of the attributes and behaviors that the "thing/object" can do. 

        //Properties
        // "Auto Implemented Properties"
        // properties are defining features about the class that will be applied to the object
        public string HairColor { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public string EyeColor { get; set; }
        public bool HasDegree { get; set; }
        public int Age { get; set; }


        // if not constructor is defined, One is GIVEN to you. it's invisible. 
        // The GIVEN constructor is an empty constructor.
        // empty constructor
        public Person()
        {

        }
        public Person(string name, string hairColor, int height)
        {
            HairColor = hairColor;
            Name = name;
            Height = height;
        }

        // this is an instance method (static is not present)
        // it's behavior will change with the object
        public string Walk()
        {
            return $"{Name} is Walking";
        }

        // static lives on the class level
        // it is class dependant, and not obj dependent
        public static string Walking()
        {
            return "I am statically walking";
        }
    }
}
