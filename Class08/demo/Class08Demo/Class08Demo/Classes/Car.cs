using Class08Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class08Demo.Classes
{
    class Car : IDrivable
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public void Accelerate()
        {
            Console.WriteLine("step on the gas! We are going faster!");
        }

        public void Brake()
        {
            Console.WriteLine("brake! brake! brake!");
        }

        public void PlayRadio()
        {
            Console.WriteLine("Music music music");
        }

        public void SetBlinker()
        {
            Console.WriteLine("Others will thank you....");
        }

        public void Start()
        {
            Console.WriteLine("push the button!");
        }

        public void TransferOwnership()
        {
            Console.WriteLine("New owner is here!");
        }
    }
}
