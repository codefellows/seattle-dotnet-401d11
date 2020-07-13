using Class06Demo.Classes;
using System;

namespace Class06Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PizzaExample();
        }

        static void PizzaExample()
        {
            PizzaStore store = new PizzaStore();
            // creating a reference to an existing instantiated pizza
            Pizza pizza  = store.OrderPizza("pepperoni");

           

            string name = pizza.Name;
            Console.WriteLine($"The pizza name is {name}");
        }
    }
}
