using System;

namespace IEnumerable_02a
{
    class Program
    {
        static void Main(string[] args)
        {

            CContenedora C = new CContenedora();

            foreach (int Valor in C)
            {
                Console.WriteLine(Valor);
            }


        }
    }
}
