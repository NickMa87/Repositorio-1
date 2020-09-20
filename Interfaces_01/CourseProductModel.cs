using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_01
{
    public class CourseProductModel : IProductModel
    {

        public string Title { get; set;}

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel Customer)
        {
            if (HasOrderBeenCompleted == false)  // Also can be expressed as !HasOrderBeenCompleted, the current way is more legible
            {
                Console.WriteLine($"Added the {Title} course to {Customer.FirstName}'s Account");
                HasOrderBeenCompleted = true;
            }
        }

    }
}
