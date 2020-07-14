using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    abstract class PizzaStore
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsOpen { get; set; }


        // methods

        public abstract Pizza CreatePizza(string type);

        // OrderPizza
        public Pizza OrderPizza(string pizzaType)
        {

            Pizza pizza = CreatePizza(pizzaType);

            //if(pizzaType == "pepperoni")
            //{
            //    pizza = new Pepperoni();
            //}
            // create pizza and return it
            // TODO: Create Pizza
         
            return pizza;
        }

        // OpenProcedures
        public void ManageHours(bool storeOpen)
        {

            if (storeOpen)
            {
                IsOpen = true;
                OpenProcedure();
                string message = "store is open";
                Console.WriteLine(message);

            }

            IsOpen = false;
            ClosingProcedure();
        }

        public virtual void OpenProcedure()
        {
          
            Console.WriteLine("These are all the things that we need to do to open");
        }


        public void ClosingProcedure()
        {
            Console.WriteLine("These are all the things that we need to do to close");
        }
    }
}
