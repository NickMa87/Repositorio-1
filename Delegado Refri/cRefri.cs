using System;
using System.Collections.Generic;
using System.Text;

namespace Delegado_Refri
{
    class cRefri
    {
        public delegate void dLowReserves(int pKg);
        public delegate void dDefrost(int pTemp);

        private int vKgFood = 0;
        private int vTemp = 0;

        private dLowReserves DelLowReserves;
        private dDefrost DelDefrost;

        public cRefri(int pK, int pD)
        {
            this.vKgFood = pK;
            this.vTemp = pD;
         
        }

        public void AdditionReserveMethod(dLowReserves pMethod)
        {
            DelLowReserves = pMethod;
        }

        public void AdditionDefrostMethod(dDefrost pMethod)
        {
            DelDefrost = pMethod;
        }

        public int KgFood
        {
            get { return vKgFood;}
        }

        public int Temp
        {
            get { return vTemp;}
        }

        public void Work(int pConsume)
        {
            vKgFood -= pConsume;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} Kilograms,{1} Degrees", vKgFood, vTemp);

            if (vKgFood < 10)
            {
                DelLowReserves(vKgFood);
            }

            if (vTemp > 0)
            {
                DelDefrost(vTemp);
            }



        }

         
           





    }
}
