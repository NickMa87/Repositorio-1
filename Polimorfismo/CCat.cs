using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class CCat : CMammal
    {
        public override void Movement()
        {
            Console.WriteLine($"The cat {Name} runs");
        }
    }
}
