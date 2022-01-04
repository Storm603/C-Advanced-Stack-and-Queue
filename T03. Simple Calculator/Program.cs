using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            int totalSum = 0;

            totalSum = int.Parse(stack.Pop());

            for (int i = stack.Count - 1; i > 0; i-=2)
            {
                if (stack.Peek() == "-")
                {
                    stack.Pop();
                    totalSum -= int.Parse(stack.Pop());
                }
                else if (stack.Peek() == "+")
                {
                    stack.Pop();
                    totalSum += int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
