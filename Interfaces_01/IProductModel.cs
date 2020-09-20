using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_01
{
    public interface IProductModel
    {
        string Title { get; set; }

        bool HasOrderBeenCompleted { get;}

        void ShipItem(CustomerModel Customer);

    }
}
