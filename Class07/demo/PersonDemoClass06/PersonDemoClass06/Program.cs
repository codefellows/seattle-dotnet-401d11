using PersonDemoClass06.Classes;
using System;

namespace PersonDemoClass06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InheritanceExample();
        }

        static void InheritanceExample()
        {
            //Person person = new Person();
            Student student = new Student("Amanda");

            //Employee employee = new Employee();
            CodeFellows cf = new CodeFellows("Sally");


            Person[] people = new Person[3];

            people[0] = new Student("amanda") { Age = 55, GPA = 10.00m, FavoriteColor = "red" };
            people[1] = new Developer("Josie Cat") { Age = 82, FavoriteColor = "red" };
            people[2] = new Developer("Belle Kitty") { Age = 40, FavoriteColor = "red" };

            foreach (Person peep in people)
            {
                if(peep is Developer)
                {
                    Console.WriteLine("I am a developer.");
                    MyPeople(peep);

                }
                else
                {
                    Console.WriteLine("I am not a developer");
                }
            }

        }

        public static void MyPeople(Person people)
        {
            Console.WriteLine(people.Name);
        }
    }
}
