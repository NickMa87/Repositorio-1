using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_01
{
    class CAula
    {

        private string NombreAula;
        private int CantidadAlumnos;

        public CAula(string pNombre, int pCantidad)
        {
            NombreAula = pNombre;
            CantidadAlumnos = pCantidad;       
        }

        public override string ToString()
        {
            string Mensaje = string.Format("El aula {0}, tiene {1} Alumnos", this.NombreAula, this.CantidadAlumnos);

            return Mensaje;
        }
    }
}
