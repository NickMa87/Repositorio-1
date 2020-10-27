using System;
using System.Collections.Generic;
using System.Text;

namespace Test_6
{
    class Class1
    {

        public Class1()
        { 
        
            this.L = new List<int>();
            this.A = new int[4];
        }

        /*
            I can use getters and setters with Data Structures, when I call the properties of the "Data Structure" type,
            like a Dictionary, using dot notation (remember that dot notation implies a "this" that links the function to the
            instance of the class) I've available the properties of such structure from the object.        
         
         */


        public Class1 C1 = new Class1();


        public int[] A
        {
            get;set;
        }


        public List<int> L
        {
            get;set;
        }

        

        

    }
}
