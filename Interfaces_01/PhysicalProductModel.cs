using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_01
{
    class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel Customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating Shipping {Title} to {Customer.FirstName} in {Customer.City}");
                HasOrderBeenCompleted = true; 
            
            
            }
        
        
        
        }
    }
}
