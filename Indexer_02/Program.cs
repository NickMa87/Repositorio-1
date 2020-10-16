using System;
using System.ComponentModel;

namespace Indexer_02
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = 0;
            
            Container C = new Container();

            for (N = 0; N < 7; N++)
            {
                Console.WriteLine($"{C[N]}");
            }
        }
    }
}
