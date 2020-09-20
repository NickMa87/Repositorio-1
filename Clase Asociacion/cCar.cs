using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Asociacion
{
    class cCar
    {

        private string vMarca;
        public string Marca
        {
            get { return vMarca; }
            set { vMarca = value; }
        }

        private string vModel;
        public string Model
        {
            get { return vModel; }
            set { vModel = value; }

        }

        private string vYear;

        public string Year
        {
            get { return vYear; }
            set { vYear = value; }
        }

    
        public cCar(string p1,string p2, string p3)
        {
            vMarca  = p1;
            vModel  = p2;
            vYear   = p3;

        }



    }
}
