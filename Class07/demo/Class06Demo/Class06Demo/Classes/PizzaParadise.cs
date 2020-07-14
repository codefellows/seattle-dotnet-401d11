using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    class PizzaParadise : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
           if(type == "pepperoni")
            {
                pizza = new GalacticPepperoni();
            }

            return pizza;
        }
    }
}
