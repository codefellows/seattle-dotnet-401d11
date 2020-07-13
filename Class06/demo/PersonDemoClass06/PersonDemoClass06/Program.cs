using PersonDemoClass06.Classes;
using System;

namespace PersonDemoClass06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void InheritanceExample()
        {
            //Person person = new Person();
            Student student = new Student("Amanda");
           
            //Employee employee = new Employee();
            CodeFellows cf = new CodeFellows("Sally");
            
            
        }
    }
}
