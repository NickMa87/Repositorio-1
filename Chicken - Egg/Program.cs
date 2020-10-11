using System;

namespace Chicken___Egg
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{Chicken()} Came first");
          
        }


        public static string Chicken()
        {
            return Egg();
        }

        public static string  Egg()
        {

            return Chicken();
        }
    }
}
