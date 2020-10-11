using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_01
{
    class CEscuela
    {
        private string vNombre;
        private CAula[] Aulas = new CAula[3];

        public CEscuela(string pNombre)
        {

           vNombre = pNombre;
        
        }

        public void ColocaAulas()
        {
            int     N           = 0;
            string  Dato        = "";
            string  Nombre      = "";
            int     Cantidad    = 0;

            for (N = 0; N < Aulas.Length; N++)
            {
                Console.WriteLine("Dame el nombre del Aula");
                Nombre = Console.ReadLine();

                Console.WriteLine("Dame la cantidad de Alumnos");
                Dato = Console.ReadLine();
                Cantidad = Convert.ToInt32(Dato);

                Aulas[N] = new CAula(Nombre, Cantidad);
            }       
        }

        public override string ToString()
        {
            string Mensaje = "";
            int N = 0;

            Mensaje = String.Format($"Bienvenidos a la escuela {vNombre}, la cual consta de \r\n");

            for (N = 0; N < Aulas.Length; N++)
            {
                Mensaje += Aulas[N].ToString() + "\r\n";
            }

            return Mensaje;

        }

    }
}
