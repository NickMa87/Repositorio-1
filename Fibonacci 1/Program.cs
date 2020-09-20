using System;
using System.Collections.Generic;

namespace Fibonacci_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var FibonacciNumbers = new List<int> { 1, 1 };


            while (FibonacciNumbers.Count < 20)
            {
                var Previous = FibonacciNumbers[FibonacciNumbers.Count - 1];
                var Previous2 = FibonacciNumbers[FibonacciNumbers.Count - 2];

                FibonacciNumbers.Add(Previous + Previous2);
            }


            foreach (var Item in FibonacciNumbers)
                Console.WriteLine(Item);


        }
    }
}

