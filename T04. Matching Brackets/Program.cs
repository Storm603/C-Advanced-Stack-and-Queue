using System;
using System.Collections;
using System.Collections.Generic;

namespace T04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Stack<int> bracketIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketIndex.Push(i);
                }
                else if (input[i] == ')')
                {
                    int closingBracket = i;
                    int openingBracket = bracketIndex.Pop();

                    Console.WriteLine(input.Substring(openingBracket, closingBracket - openingBracket + 1));
                }
            }
        }
    }
}
