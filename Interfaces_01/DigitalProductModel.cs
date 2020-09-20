using System;

namespace Interfaces_01
{
    class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;
        public void ShipItem(CustomerModel Customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {Customer.EmailAddress}");

                TotalDownloadsLeft -= 1;

                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;

                    TotalDownloadsLeft = 0;
                
                }
            }
        }

        


    }
}
