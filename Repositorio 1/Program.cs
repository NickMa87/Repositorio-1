using System;
using System.Collections.Generic;

namespace Repositorio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i; 

            List<string> Names = new List<string> { "<Name>", "Ana", "Felipe" };

            Names.Add("Maria");
            Names.Add("Bill");
            Names.Remove("Ana");

            foreach (var name in Names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // Other way to say the same

            for (i = 0; i < Names.Count; i++)
            {
                Console.WriteLine("Hello"+" "+ Names[i]);
            }


        }
    }
}


