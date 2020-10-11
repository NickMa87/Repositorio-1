using System;

namespace Composition_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CEscuela Escuela = new CEscuela("Nick's School");

            Escuela.ColocaAulas();

            Console.WriteLine(Escuela);


        }
    }
}
