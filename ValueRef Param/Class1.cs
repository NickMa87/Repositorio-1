using System;
using System.Collections.Generic;
using System.Text;

namespace ValueRef_Param
{
    class CReferencias
    {

        private void TestRef(ref int uno, int dos)
        {
            uno = uno + dos;
            dos = 1700;                 //The IDE detects that "dos" is going nowhere
        }

        public void TestingRef()
        {

            int uno = 5;
            int dos = 6;

            Console.WriteLine("Uno equals {0} Dos equals {1}", uno, dos);
            TestRef(ref uno, dos);
            Console.WriteLine($"Uno equals {uno},Dos equals{dos}");
            
        
        }


    }
}
