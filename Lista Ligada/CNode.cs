using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Ligada
{
    class CNode
    {

        private int Data;

        private CNode _Next = null; 
        public int Data1 { get => Data; set => Data = value; }

        internal CNode Next { get { return _Next; }  set { _Next = value; } }

        public override string ToString()
        {
            return string.Format($"[{Data}]");
        }

    }
}
