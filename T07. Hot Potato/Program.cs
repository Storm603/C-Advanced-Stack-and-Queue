using System;
using System.Collections.Generic;

namespace T07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            int jump = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(names);

            while (kids.Count > 1)
            {
                for (int i = 0; i < jump - 1; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }

                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
