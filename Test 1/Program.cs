using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Test_1
{
    class program
    {
        public static void Main(string[] args)
        {
            bool Primo;
            int N;
            int M;

            for (N = 2 ; N < 100; N++)
            {
                Primo = true;
                for (M = 2; M < N; M++)
                {
                    if (N % M == 0)
                        Primo = false;
                
                }

                if (Primo == true)
                    Console.Write("\n"+"{0}", N);
            
            }



        } 
        
    }
  
}
