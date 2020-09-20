using System;
using System.Collections.Generic;
using System.Text;

namespace Delegados
{
    class cRadio
    {
        public static void RadioMethod(string pMessage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("We are in the radio Class");
            Console.WriteLine($"This is your message : {pMessage}");
        
        }


    }
}
