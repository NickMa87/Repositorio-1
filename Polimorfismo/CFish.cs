using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class CFish : CMammal
    {


        public override void Movement()
        {
            Console.WriteLine($"The fish {vName} swims");
        }
    }
}
