using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml;

namespace Indexer_03
{
    class CData 
    {
        CNode[] Arr;
  
        public CData()
        {
          Arr = new CNode[9]    {
                                    new CNode(), new CNode(), new CNode(),
                                    new CNode(), new CNode(), new CNode(),
                                    new CNode(), new CNode(), new CNode()
                                };
        }
               
        public CNode this[int Index]
        {
            get 
            {
               return Arr[Index];
            }
        
        }

        public int Count { get; } = 9;


     

    }
}
