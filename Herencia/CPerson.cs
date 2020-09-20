using System;
using System.Collections.Generic;
using System.Text;

namespace Program_04_01_Ineritance
{

   public class CPerson

    {
        private string  vName;
        private int     vAge;
        protected int test = 0;



        protected string Name
        {
            get
            {
               return vName;
            }

            set
            {
                vName = value;
            }    
        }


        public int Age
        {
            get
            {
                return vAge;
            }

            set
            {
                if (value >= 18)
                    vAge = value;
                else
                { 
                  vAge = -1;
                  Console.WriteLine("Not allowed Age");      
                }
            }        
        }


        public void Show()
        {
            Console.WriteLine($"Name is {vName}, age is {vAge}");
        }

    }
}
