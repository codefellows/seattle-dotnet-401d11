using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    class PizzaPlanet : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type.ToLower().Trim())
            {
                case "cheese":
                    pizza = new Cheese();
                    break;
                case "pepperoni":
                    Console.WriteLine("I have made pepperoni");
                    pizza = new Pepperoni();
                    break;
                default:
                    break;
            }

            return pizza;
        }

        public override void OpenProcedure()
        {
            Console.WriteLine("We are releasing the aliens!!");
        }
    }
}
