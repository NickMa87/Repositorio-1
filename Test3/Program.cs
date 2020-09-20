using System;
using System.Globalization;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            SentenciaContinue();
        }

        public static void SentenciaContinue()
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine("\t" + i);
            
            }

            int j = 0;

            while (j < 10)
            {
                j++;
                if (j % 2 == 0)
                    continue; 
                Console.WriteLine("\t" + j);
            }
        
        }
    }
}
