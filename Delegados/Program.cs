using System;

namespace Delegados
{
    class Program
    {
        public delegate void MyDelegate(string M);
     
        static void Main(string[] args)
        {
            MyDelegate Delegate = new MyDelegate(cRadio.RadioMethod);           

            Delegate("Hello Everyone");

            Delegate = new MyDelegate(cCake.ShowCake);

            Delegate("Happy Birthday");

             
        }
    }
}
