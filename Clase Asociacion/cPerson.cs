using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Asociacion
{
    class cPerson
    {
        private string vName;
        private string vLastName;
        private string vDNI;

        public string Name
        {
            get { return vName  ;}
            set { vName = value ;}
        }

        public string LastName
        {
            get { return vLastName  ;}
            set { vLastName = value ;}
        }

        public string DNI
        {
            get { return vDNI   ;}
            set { vDNI = value  ;}
        }



        public cPerson(string N, string L, string D)
        {
            vName = N;
            vLastName = L;
            vDNI = D;        
        }

    }
}
