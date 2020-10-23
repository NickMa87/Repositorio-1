using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Indexer_02
{
    class Container
    {
        String[] DayOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


      
        public String this[int X]
        {
            get {
                    if (X > 7 || X < 0) return "Out of range";
                    return DayOfTheWeek[X]; 
                }                
        }
    }
}
