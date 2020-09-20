using System;
using System.Collections.Generic;
using System.Text;

namespace Programa_03_1_Indexer
{
    class CTiendaAutos
    {

        CAuto[] Disponibles = new CAuto[2] { new CAuto("3000", 3000), new CAuto() };


        public int[] Array = new int[3];

        


        public void Method()
        {
            

            Disponibles[0] = new CAuto("Porsche", 50000);


            for (int N = 0; N < Array.Length; N++)
            {
                Disponibles[N].MuestraInformacion();
            }
       
        }


       private int N;

        

        public CTiendaAutos()
        {
            
            Disponibles[0] = new CAuto("Porsche",   50000);

            //Disponibles[1] = new CAuto("Fit"    ,   30000);

            //Disponibles[2] = new CAuto("March"  ,   168900);

            //Disponibles[3] = new CAuto("Spark"  ,   160300.00);
        }

        public CAuto this[int Indice]
        {
            get { 

                return Disponibles[Indice]; 
                
                }

            set { 
                
                Disponibles[Indice] = value; 
                
                }
        }
    }
}
