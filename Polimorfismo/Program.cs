using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            CMammal pMammal = new CMammal();

            string  vOption;
            int     vOption1;

            Console.WriteLine("Select an Option " + "\n" + "1 - Cat " + "\n" + "2 - Dog" + "\n" + "3 - Fish");
            vOption = Console.ReadLine();
            vOption1 = Convert.ToInt32(vOption);

            Console.WriteLine("Select a name for the Mammal");
            pMammal.Name = Console.ReadLine();


            if (vOption1 == 1)
            {

                pMammal = new CCat();

                pMammal.Movement();            
            
            }


           
            

            
            
            


            pMammal = new CDog();
            pMammal = new CFish();

          
        }
    }
}
