using System;
using System.Collections.Generic;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> collection = new Stack<char>();

            foreach (char letter in input)
            {
                collection.Push(letter);
            }

            while (collection.Count > 0)
            {
                Console.Write(collection.Pop());
            }

        }
    }
}
