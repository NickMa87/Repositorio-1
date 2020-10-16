using System;

namespace Indexer_03
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;

            CData D = new CData();

            

            for (N = 0; N < D.Count; N++)
            {
                Console.WriteLine($"{D[N]}");
            }




        }
    }
}
