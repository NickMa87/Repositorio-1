using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_01
{
    public interface IDigitalProductModel : IProductModel
    {
        public int TotalDownloadsLeft { get; }

    }
}
