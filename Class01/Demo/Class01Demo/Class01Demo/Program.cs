using System;

namespace Class01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to .NET!");
            // int answer = MyNumber(10);
            // Console.WriteLine($"My number is {answer}");
            //TryCatchExample();
            // TryCatchExample2();

            try
            {
                MethodA();

            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception caught in Main: {e.Message}");
            }

            Console.WriteLine("Program is done");
        }

        static int MyNumber(int int1)
        {
            return int1;
        }

        static void TryCatchExample()
        {
            // This is a comment in C#
            string number = "twenty";

            try
            {
                int twenty = Convert.ToInt32(number);
                Console.WriteLine(twenty);
            }

            catch (FormatException f)
            {
                Console.WriteLine($"{number} is not a number");
                // in ILogger send the f.Message

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }


        static void TryCatchExample2()
        {
            try
            {
                Console.WriteLine("Enter a number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong format");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You attempted to divide by zero");
            }
            finally
            {
                Console.WriteLine("I  am done");
            }

            Console.WriteLine("Thank you");

        }

        static void MethodA()
        {
            try
            {
                Console.WriteLine("In Method A");
                MethodB();
            }
            catch (Exception)
            {
                Console.WriteLine("In Method A");
                throw;
            }
        }

        static void MethodB()
        {
            try
            {
                Console.WriteLine("In Method B");
                MethodC();
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught in B");
                // throw;
                Console.WriteLine($"Exception caught in Main: {e.Message}");
            }
        }

        static void MethodC()
        {
            Console.WriteLine("In Method C");
            throw (new Exception("this is my Method C Exception"));
        }

    }
}
