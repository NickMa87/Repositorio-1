using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Programa_03_1_Indexer
{
    public class CAuto
    {

        double Costo;
        double Tenencia;
        string Modelo;


        public CAuto(string pModelo, double pCosto)
        {
            Costo = pCosto;
            Modelo = pModelo;

        }

        public CAuto()
        {
            Console.WriteLine("Constructor de CAuto");
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Tu automotor {Modelo}");
            Console.WriteLine("Costo {0}", Costo);
     
        }


    }
}
