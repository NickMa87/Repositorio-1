using System;
using System.Collections.Generic;
using System.Transactions;

namespace Indexer_04
{
    class Program
    {
     
        static void Main(string[] args)
        {

            int i=0; 

            MyType[] MyTypes = new MyType[3];

            MyTypes[0] = new MyType();
            MyTypes[1] = new MyType();
            MyTypes[2] = new MyType();


            for (int current = 0; current < MyTypes.Length; ++current)
            {

                MyTypes[current].Values.Add("a", current);
                MyTypes[current].Values.Add("b", "myBvalue");
                MyTypes[current].Values.Add("c", (ushort)current + ">>A");

            }


            //MyTypes[0].Values.Add("a", "Value a");
            //MyTypes[1].Values.Add("b", "Value b");
            //MyTypes[2].Values.Add("c", "Value c");

            foreach (var current in MyTypes)
            {
                i++;

                    Console.WriteLine(
                       string.Format("A={0}, B={1}, C={2}",
                                      current.Values["a"],
                                      current.Values["b"],
                                 current.Values["c"]));
            }



        }







        
    }
}
