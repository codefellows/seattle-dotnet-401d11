using DemoClass09.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoClass09
{
    // Delegate declaration
    delegate void MyDelegate();

    delegate bool GetNumbers(int n);
    // the compiler creates for us class MyDelegate signature

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //MyDelegate del = new MyDelegate(MyMethod);
            ////del();
            ////del.Invoke();

            ////MyDelegate delly = MyMethod;
            ////   PassingADelegate(del);
            ////MyMethod();
            ////GetAllEvenNumbers PassingADelegate(MyMethod);
            //IEnumerable<int> numbers = GetAllEvenNumbers(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 });
            //IEnumerable<int> oddNumbers = GetAllOddNumbers(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 });

            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var allEvenNumbers = GenerateNumbers(nums, n => n % 2 == 0);
            //var allTheOddNumbers = GenerateNumbers(nums, n => n % 2 != 0);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in oddNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //  BasicLINQ();

            MethodCalls();

        }


        #region demo1 delegates
        //static bool IsEven(int n)
        //{
        //    if (n % 2 == 0)
        //    {
        //        return true;
        //    };
        //}

        static void MyMethod()
        {
            Console.WriteLine("I am in a method");
        }

        static void PassingADelegate(MyDelegate delly)
        {
            Console.WriteLine("we are in a method that passes in a delegate");
            delly();
        }


        static IEnumerable<int> GetAllEvenNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    yield return numbers[i];
                }

            }
        }

        static IEnumerable<int> GetAllOddNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    yield return numbers[i];
                }
            }
        }


        static IEnumerable<int> GenerateNumbers(IEnumerable<int> numbers, GetNumbers action)
        {
            foreach (var item in numbers)
            {
                if (action(item))
                {
                    yield return item;
                }
            }
        }

        static void OtherExample()
        {
            // Funcs ALWAYS have return types
            Func<int, int, string> myFunct = ThisTakesInTwoIntegersAndRetrunsAString;

            // Actions do not have return tupes
            Action<int> myAction = MyIntAction;
        }

        static string ThisTakesInTwoIntegersAndRetrunsAString(int a, int b)
        {
            return "Candy";
        }

        static void MyIntAction(int x)
        {

        }

        #endregion


        #region LINQ demo

        static void BasicLINQ()
        {
            Person[] persons =
            {
                new Person ("Kate", "Austin", 33),
                new Person ("Jack", "Shepard", 39),
                new Person ("James", "Ford", 19),
                new Person ("Ben", "Linus", 23),
                new Person ("Hugo", "Reyes", 20),

            };

            /*
             SELECT * FROM TABLE WHERE CONDITION

            SELECT FirstName, LastName --> "Projection"
            From persons --> Data Source
            WHERE Age > 21 --> Filter
            Order By Age DESC --> Sorting
             */

            // et every single person in my array aboyve
            var query = from person in persons
                        select person;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            // "complex" linq query
            var query2 = from person in persons
                         where person.Age > 21
                         orderby person.Age descending
                         select person;

            foreach (var item in query2)
            {
                Console.WriteLine(item.FirstName);
            }

            // anonymous objects...objects that we define ourselves..without a class file

            var anonObjs = from potato in persons
                           where potato.Age > 21
                           select new { FName = potato.FirstName, LName = potato.LastName };

            foreach (var item in anonObjs)
            {
                Console.Write(item.FName);
                Console.Write(item.LName);
                Console.WriteLine();
            }

        }

        static void MethodCalls()
        {

            Person[] persons =
            {
                new Person ("Kate", "Austin", 33),
                new Person ("Jack", "Shepard", 39),
                new Person ("James", "Ford", 30),
                new Person ("Ben", "Linus", 23),
                new Person ("Hugo", "Reyes", 20),

            };

            var query = persons.Select(x => new { x.FirstName, x.LastName });

            // get all the people who have a's in their first name nad 
            IEnumerable<Person> query2 = persons.Where(peep => peep.Age > 21 && peep.FirstName.Contains('a'));

            var result = query2.Where(x => x.Age > 35);

            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName);
            }

            var chaining = persons.Where(x => x.Age > 21)
                                  .OrderBy(x => x.Age)
                                  .Select(potato => new { potato.FirstName, potato.LastName });

            var example = persons.Where(person => person.Age > 21)
                                 .OrderByDescending(person => person.Age)
                                  .Skip(2)
                                  .Take(1)
                                  .Select(person => new { person.Age});

        }

        // Lazy Loading (deferred execution)
        // the items are not loaded until they are needed. 
        // distributes the performance across the whole traversal and not all at once

        // .Where
        // example: Foreach loop


        // Eager Loading (immediate execution)
        // all items are loaded right away. performance is frontloaded to the inial load.

        // .ToList() <-- eager loading
        // query to a database "Go through this list and add every student to the db
        // db errors >> "entity error" solution is to ToList your collection you're going though.
        
        // .Sum() 
        // .Skip()
        // .Take()
        #endregion


    }
}
