using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Class08Demo.Classes
{
     // the <T> tells us that this is a generic with any Type. 
     // the "T" can be anything example: <Type> <Candy> <Potato>
     // whatever you define in the class sig. must be consistent across the class. 
    class NumberList<T> : IEnumerable<T>
    {
        T[] items = new T[5];
        int count; 

        public void Add(T item)
        {
            // evaluate the length of items vs the count. 
            if(count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;

            //// if count = 3
            //count++;  // output 3, and then incrament to 4
            //++count; // incrament to 4, then output 4
        }

        public int Count()
        {
            return count;
        }

        // If something is enumerable (interface)
        // you need an enumerator ("get enumerator"_
         // to be able to enumerate through generic collections

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                // yield break
                yield return items[i];
            }

        }

        // Foreach does not require IEnumerable
        // Ienumerator only requires the GetEnumerator (non-generic)
        // Non-generic getenumerator requires teh generic GetEnumerator

        // Enumerable - means it can be iterated through
        // Enumerator - is the actual "thing" that walks through the sequence through the list

        // Magic, don't touch.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
