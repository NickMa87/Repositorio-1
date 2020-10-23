using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_04
{
    class MyType
    {
        public MyType()
        {
            this.Values = new Dictionary<object, object>();   
        }

        public Dictionary<object, object> Values
        {
            get;
            set;
        }


    }
}
