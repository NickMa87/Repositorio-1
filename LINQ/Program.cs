using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string Uno;
            int Dos;

            Console.WriteLine("1 Para simple \n 2 Para complejo \n 3 Para iteracion de complejo");
            Uno = Console.ReadLine();
            Dos = Convert.ToInt32(Uno);

            if (Dos == 1)
            {

                int[] Vec = { 1, 2, 6, 4, 2, 1, 9, 10, 100, 22, 4, 3, 33 };



                IEnumerable<int> Lst = from Alias in Vec
                                       where Alias == 2
                                       orderby Alias
                                       select Alias;

                foreach (int a in Lst)
                {
                    Console.WriteLine(a);

                }

                Console.ReadKey();

            }
            else if (Dos == 2)
            {

                Complejo[] List =
                {

                new Complejo(1, "Auto"),
                new Complejo(2, "Gato"),
                new Complejo(3, "Labrador"),
                new Complejo(10, "Telefono"),
                new Complejo(22,"Item")

                };

                Console.Clear();
                Console.Write("I print a single value from Complejo Object \n\n\n");

                var oItem = (from Alias in List
                             where Alias.Numero == 22
                             select Alias).FirstOrDefault();

                Console.Write(oItem.Imprime());

                Console.ReadKey();

            }

            else
            {

                Complejo[] List =
                  {

                new Complejo(1, "Auto"),
                new Complejo(10, "Gato"),
                new Complejo(4, "Labrador"),
                new Complejo(2, "Telefono"),
                new Complejo(22,"Item")

                };

                Console.Clear();
                Console.Write("I print a foreach Iteracion for all values in Complejo Object \n\n\n");

                IEnumerable<Complejo> oItem = from Alias in List
                                                orderby Alias.Numero
                                                select Alias;

                foreach (Complejo V in oItem)
                {
                    Console.Write(V.Imprime());
                }




                Console.ReadKey();





            }
        }
    }

    public class Complejo
    {
        public int Numero { get; private set; }
        public string Cadena { get; private set; }

        public Complejo(int pNumero, string pCadena)
        {
            this.Numero = pNumero;
            this.Cadena = pCadena;

        }

        public String Imprime()
        {

            return Numero + " " + Cadena + "\n";


        }
    }
}
