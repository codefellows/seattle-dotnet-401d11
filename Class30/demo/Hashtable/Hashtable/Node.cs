using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class Node<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }

        public Node(T value, string key)
        {
            Key = key;
            Value = value;
        }
    }
}
