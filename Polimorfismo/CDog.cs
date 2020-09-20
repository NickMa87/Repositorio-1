using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class CDog : CMammal
    {
        public override void Movement()
        {
            Console.WriteLine($"The dog {vName} do the Dog stuff");
        }
    }
}
