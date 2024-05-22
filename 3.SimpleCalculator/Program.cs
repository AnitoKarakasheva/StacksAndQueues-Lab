using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> tokens = new(
    Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Reverse());

            int result = int.Parse(tokens.Pop());

            while (tokens.Count > 0)
            {
                string operation = tokens.Pop();

                if (operation == "+")
                {
                    result += int.Parse(tokens.Pop());
                }
                else if (operation == "-")
                {
                    result -= int.Parse(tokens.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}
