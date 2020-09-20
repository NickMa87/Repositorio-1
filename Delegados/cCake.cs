using System;
using System.Collections.Generic;
using System.Text;

namespace Delegados
{
    class cCake
    {
        public static void ShowCake(string pMessage)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The cake will have the following message {0}", pMessage);
        
        }
    }
}
