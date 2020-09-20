using System;

namespace Delegado_Refri
{
    class Program
    {
        static void Main(string[] args)
        {
            cRefri MyRefri = new cRefri(70, -20);
            Random Rnd = new Random();

            MyRefri.AdditionReserveMethod(new cRefri.dLowReserves(informKg));
            MyRefri.AdditionDefrostMethod(new cRefri.dDefrost(informDegree));


            while (MyRefri.KgFood > 0)
            {
                MyRefri.Work(Rnd.Next(1, 5));           
            }
        }




        public static void informKg(int vKg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Low food reserve");
            Console.WriteLine("--> There are {0} kg remaining of food",vKg);
        
        }

        public static void informDegree(int vD)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> The refri is defrosting, main level correlation");
            Console.WriteLine("--> The refri is {0} degrees",vD);       
        }
    }
}
