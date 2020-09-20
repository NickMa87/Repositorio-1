using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IEnumerable_01
{
    class CTiendaAutos
    {
        private CAuto[] Disponibles;

        public CTiendaAutos()
        {
            Disponibles = new CAuto[4];

            Disponibles[0] = new CAuto("Soul", 220000.50);
            Disponibles[1] = new CAuto("Fit", 175700.80);
            Disponibles[2] = new CAuto("Porsche", 50000.50);
            Disponibles[3] = new CAuto("McLaren", 15000.80);

        }
            public IEnumerator GetEnumerator()
            {

                return Disponibles.GetEnumerator();

            }
        

    }
}
