using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class CMammal
    {
        protected string vName;

        public string Name
        {
            get { return vName;}
            set { vName = value; }       
        }

        public virtual void Movement()
        {

            Console.WriteLine("The Mammal moves");

        }




    }
}
