using System;

namespace Test4
{
    class Program
    {

        private static int i;

        private static char[] CrearVec()
        {
            char[] V;

            V = new char[26];

            for (i = 0; i < V.Length; i++)
            {
                V[i] = (char)('A' + i);
            }

            return V;
        }

        private static void ImprimirVec(char[] pVec)
        {
            char[] pV = pVec;
            
            Console.Write('<');

            for (int i = 0; i < pV.Length; i++)
            {
                Console.Write($"{pV[i]}");
                if ((i + 1) < pV.Length)
                {
                    Console.Write(',');     
                }

            }

            Console.Write('>');
        
        }

        public static void Main()
        {
            char[] Var = CrearVec();
            ImprimirVec(Var);      
         
        }
        




    }
}
