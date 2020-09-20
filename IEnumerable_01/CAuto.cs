using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumerable_01
{
    class CAuto : IAutomovil
    {
        double Costo;
        double Tenencia;
        string Modelo;

        public CAuto(string pModel, double pCost)
        {
            Costo = pCost;
            Modelo = pModel;        
        }


        public void CalculaTenencia(double pImpuesto)
        {
            Tenencia = 5000 + Costo * pImpuesto;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu automovil{Modelo}");
            Console.WriteLine($"Costo {Costo} con tenencia {Tenencia}");
            Console.WriteLine($"Total{Costo + Tenencia}");
        
        
        }

    }
}
