using System;

namespace IEnumerable_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CTiendaAutos Tienda = new CTiendaAutos();

            foreach (CAuto MiAuto in Tienda)
            {
                MiAuto.CalculaTenencia(0.5);
                MiAuto.MuestraInformacion();
            
            }


        }
    }
}
