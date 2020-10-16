using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Indexer_03
{
    class CNode
    {
        public int Index { get; private set; }
        public int Col1 { get; private set; }
        public int Col2 { get; private set; }
        public int Col3 { get; private set; }

        private static int Increment=0;
        int X;


        public CNode()
        {
            X = ++Increment;
            
            Index   = X;
            Col1    = 2 * X;
            Col2    = 3 * X;
            Col3    = 4 * X;


        }

        public override string ToString()
        {
            Console.WriteLine("=========================================\n");
            
            return "Index:" + Index.ToString() + "\n" + "Col 1:" + Col1.ToString() + "\n"
                    + "Col 2:" + Col2.ToString() + "\n"
                    + "Col 3:" + Col3.ToString() + "\n";
            
        }



    }
}
