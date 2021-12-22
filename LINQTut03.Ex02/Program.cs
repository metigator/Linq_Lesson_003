using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut03.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var evenNumbers = numbers.Where(x => x % 2 == 0);
            IEnumerable<int> evenNumbers = 
                numbers.Where(x => x % 2 == 0); // construction (lazy loading)
    
            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            // [1]  ===>   2, 4, 6, 8
            // [2]  ===>   2, 6, 8, 10, 12
            foreach (var n in evenNumbers) // enumeration (immediate execution)
            {
                Console.Write($" {n}");
            }

            Console.ReadKey();
        }
    }
}
