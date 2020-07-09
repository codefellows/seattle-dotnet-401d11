using DemoClass04.Classes;
using System;

namespace DemoClass04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PersonExample();
            ReferenceExample();
        }

        static void PersonExample()
        {
            // instantiate a object from a class

            // simialr to the way we create variable
            // TYPE name = "new" TYPE *Invoice Constructor*()
            // instantiated a person from the Person class
            // potato is an object.
            Person potato = new Person();

            potato.Name = "Josie  Cat";
            potato.Age = 9;
            potato.EyeColor = "green";
            potato.HairColor = "gray/white";

            Console.WriteLine($"{potato.Name} is {potato.Age} years old. They have {potato.EyeColor} eyes and {potato.HairColor} color hair");

            Person goober = new Person();

            // Setting of name
            goober.Name = "Belle Kitty";
            goober.Age = 15;
            goober.EyeColor = "blue";
            goober.HairColor = "brown";

            // This GETS The value of name in goober
            Console.WriteLine($"{goober.Name} is {goober.Age} years old. They have {goober.EyeColor} eyes and {potato.HairColor} color hair");

            Console.WriteLine($"{potato.Name} and {goober.Name} are best friends!");


            Person duck = new Person("Amanda", "Brown", 63);
            duck.Age = 55;
            duck.EyeColor = "brown";
            Console.WriteLine($"{duck.Name} is {duck.Age} years old. They have {duck.EyeColor} eyes and {duck.HairColor} color hair");

            int[] arrays = new int[] { 1, 2, 3 };

            // object initializer
            Person person = new Person()
            {
                Name = "Harry Potter",
                EyeColor = "Green",
                Age = 45,
                HairColor = "Black",
                HasDegree = false,
            };

            goober.Walk();

            Person.Walking();



        }
        
        public static void ReferenceExample()
        {
            Person original = new Person()
            {
                Name = "I am the original",
                Age = 10,
                EyeColor = "purple"
            };

            Person copyCat = original;

            Console.WriteLine($"Original Name: {original.Name}");
            Console.WriteLine($"CopyCat Name: {copyCat.Name}");

            original.Name = "Oops, i've changed!";

            Console.WriteLine($"Original Name: {original.Name}");
            Console.WriteLine($"CopyCat Name: {copyCat.Name}");

            copyCat.Name = "JK. i'm the copycat!";

            Console.WriteLine($"Original Name: {original.Name}");
            Console.WriteLine($"CopyCat Name: {copyCat.Name}");

            Person newPerson = new Person()
            {
                Name = "Candy Cane"
            };

            copyCat = newPerson;

            Console.WriteLine($"Original Name: {original.Name}");
            Console.WriteLine($"CopyCat Name: {copyCat.Name}");
            Console.WriteLine($"NewPerson Name: {newPerson.Name}");



        }
    }
}
