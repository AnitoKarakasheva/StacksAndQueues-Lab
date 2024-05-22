using System;
using System.Collections.Generic;

namespace _1.ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
        
            

            string input = Console.ReadLine();

            Stack<char> reversed = new();

            foreach (char ch in input)
            {
                reversed.Push(ch);
            }

            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }

            //Stack<char> reversed = new(input.ToCharArray());
            //Console.WriteLine(string.Join("", reversed));
        }
    }
}
