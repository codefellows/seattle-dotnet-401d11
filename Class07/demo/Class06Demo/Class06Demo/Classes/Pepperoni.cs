using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Class06Demo.Classes
{
    class Pepperoni : Pizza
    {
        public Pepperoni()
        {
            Toppings = new string[]{"Cheese","Pepperoni", "MOOOOOR pepperoni" };
            Price = 15.00m;
            Name = "Pepperoni Suprise";
        }
    }
}
