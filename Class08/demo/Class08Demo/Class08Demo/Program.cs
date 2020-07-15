using Class08Demo.Classes;
using Class08Demo.Interfaces;
using System;
using System.Collections.Generic;

namespace Class08Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //  EnumExample();
            //Boat boat = new Boat();
            //InterfaceExample(boat);

            //Car car = new Car();
            //InterfaceExample(car);

            //IDrivable[] drivables = new IDrivable[] { boat, car };

            //for (int i = 0; i < drivables.Length; i++)
            //{
            //    drivables[i].Brake();
            //}
            //  CollectionExample();
            NumbersListExample();
        }

        static void InterfaceExample(IDrivable drivable)
        {
            drivable.Accelerate();
        }

        static void EnumExample()
        {
            Days day = Days.Sunday;
            Console.WriteLine($"Convert to int {(int)day}");
            Console.WriteLine($"Convert to Day of Week{(Days)1}");
        }


        static void CollectionExample()
        {
            // differernt ways to group together objects
            // Arrays
            // Collections - dynamic, flexible, allow us to "just add items to a list" without the "concern" of memory
            // Dictionary <key, value> pair. 
            // Collection IS A CLASS!
            // Generic = one data type
            // non-generic == mix of data types. 

            List<string> myList = new List<string>()
            {
                "Cougar",
                "Chubbs"
            };
            myList.Add("Josie Cat");
            myList.Add("Belley");
            myList.Add("Leia");
            myList.Add("Frodo");
            myList.Add("Trinity");
            myList.Add("Neo");

            foreach (string cat in myList)
            {
                Console.WriteLine(cat);
            }

            myList.Remove("Belley");
            Console.WriteLine("==============");
            foreach (string cat in myList)
            {
                Console.WriteLine(cat);
            }

            Console.WriteLine("======= with a for loop =========");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Dictionary<string, int> myItems = new Dictionary<string, int>();
            myItems.Add("Monday", 1);
            myItems.Add("Tuesday", 2);

            Console.WriteLine("===== dictionary ========");
            Console.WriteLine(myItems["Monday"]);



        }

        static void NumbersListExample()
        {
            NumberList<int> numbers = new NumberList<int>();

            numbers.Add(4);
            numbers.Add(8);
            numbers.Add(15);
            numbers.Add(16);
            numbers.Add(23);
            numbers.Add(42);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            NumberList<int> myNumbers = new NumberList<int>()
            {
                100,
                200,
                300,
                400,
                500
            };

            



        }
    }
}
