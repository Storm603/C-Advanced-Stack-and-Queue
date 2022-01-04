using System;
using System.Collections.Generic;
using System.Linq;

namespace T02__Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (int number in input)
            {
                stack.Push(number);
            }

            string action = String.Empty;

            while ((action = Console.ReadLine().ToLower()) != "end")
            {
                string[] command = action.Split();

                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    if (int.Parse(command[1]) <= stack.Count)
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            int totalSum = 0;
            foreach (int number in stack)
            {
                totalSum += number;
            }

            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
