using System;

namespace Class02UnitTests
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //MyMethod()
        }


        /// <summary>
        /// This is a summary comment that tells me what my Method's sole purpose in life is. 
        /// </summary>
        /// <param name="value">value of 1</param>
        /// <param name="val2"></param>
        /// <param name="candy"></param>
        /// <returns></returns>
       public static int MyMethod(int value, int val2, string candy)
        {
            Console.WriteLine("My method is activated");

            // Api calls out to somewhere,...tell me what your expecting back
            // db call...tell me what you're expecting back

            // iteration through an array that is consturcting an object...tell me what's being constructed and why

            return value * 2;
        }


        public static string FizzBuzz(int number)
        {
            if(number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if(number % 3 == 0)
            {
                return "Fizz";
            }

            if(number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
