using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Asociacion
{
    class MiddleClass
    {
        /*

         This is the class in charge to manage the many to many relationships between Car And Person objects, one Car can be assigned to multiple
         people and one person can be assigned to multiple Cars.

         */

        private cPerson oPerson = null;
        public cPerson Person
        {
            get { return oPerson; }
            set { oPerson = value; }
        }

        private cPerson[] aPersons;
        public cPerson[] Persons
        {
            get { 
                    if (aPersons.Length == 0) return null;
                    else return aPersons; 
                }

            set { aPersons = value; }        
        }

        private cCar oCar;

        public cCar Car
        {
            get { return oCar;}
            set { oCar = value;}
        }

        private cCar[] aCar;

        public cCar[] Cars
        {
            get { 
                    if (aCar.Length == 0) return null;
                    else return aCar;
                }

            set { aCar = value; }
        
        }

        public MiddleClass(cCar p1, cPerson[] p2)
        {
            oCar = p1;
            this.aPersons = p2;

        }

        public MiddleClass(cPerson p1, cCar[] p2)
        {
            oPerson = p1;
            this.aCar = p2;
        

        }




    }
}
