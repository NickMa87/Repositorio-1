using System;

namespace Test_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 C = new Class1();

            Console.WriteLine($"{C.C1.A.Length.ToString()}");

            
            int X = C.A.Length;

            C.A[0] = 20;
            C.A[1] = 21;
            C.A[2] = 22;
            C.A[3] = 23;

            for (int N = 0; N < C.A.Length; N++)
            {

                Console.WriteLine($"In the index {N}, the value {C.A[N]} is stored");
                
            }


        }
    }
}
