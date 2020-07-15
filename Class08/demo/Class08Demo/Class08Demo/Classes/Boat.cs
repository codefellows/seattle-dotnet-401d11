using Class08Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class08Demo.Classes
{
    class Boat : IDrivable
    {
        public void Accelerate()
        {
            Console.WriteLine("go as fast as possible");
        }

        public void Brake()
        {
            Console.WriteLine("avoid the rocks!");
        }

        public void SetBlinker()
        {
            Console.WriteLine("We use the horn!");
        }

        public void Start()
        {
            Console.WriteLine("use the key!");
        }
    }
}
