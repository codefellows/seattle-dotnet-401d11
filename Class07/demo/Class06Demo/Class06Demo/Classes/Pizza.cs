using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    abstract class Pizza
    {
        public string Name { get; set; }
        public string[] Toppings { get; set; }
        public decimal Price { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public Pizza()
        {
            //Dough = "hand Tossed";
            //Sauce = "Marinara";
            //if(type == "cheese")
            //{
            //    Name = "Cheese";
            //    Toppings = new string[] { "cheese", "more cheese", "all the cheese" };
            //    Price = 10.00m;

            //} else if(type == "pepperoni"){
            //    Name = "pepperoni";
            //    Toppings = new string[] { "pepperoni", "cheese" };
            //    Price = 10.00m;
            //}
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare the pizza");
        }

        public void Bake(string baketype)
        {
            if (baketype == "wood fired")
            {
                Console.WriteLine("wood fired pizza is good");

            }
            else if (baketype == "party pizza")
            {
                Console.WriteLine("These party pizzas are delicious!");
            }
            else if (baketype == "oven")
            {
                Console.WriteLine("We preheated the oven for 425 degrees");
            }
        }

        public void Cut(int numberOfSlices)
        {
            // some magic logic here
            Console.WriteLine($"We cut the pizza into {numberOfSlices} slices");
        }

        public void Eat()
        {
            Console.WriteLine("NOM NOM NOM!");
        }


    }
}
