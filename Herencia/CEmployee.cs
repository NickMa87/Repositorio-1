using System;
using System.Collections.Generic;
using System.Text;

namespace Program_04_01_Ineritance
{
    public class CEmployee : CPerson        /* Here I declare the inheritance */
    {

        protected string vJob;
        protected double vSalary;


      
    
        private void Method()
        {

           test = 0;
         
        }


        public string Job
        {
            get
            {
                return vJob;
            }

            set
            {
                vJob = value;
            }
        }

        public double Salary
        {
            get
            {
                return vSalary;
            }

            set
            {
                vSalary = value; 
            }
        
        }


    }
}
