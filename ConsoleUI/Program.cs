using System;
using Interfaces_01;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Interfaces_01c
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PhysicalProductModel> Cart = AddSampleData();

            CustomerModel Customer = GetCustomer();

            foreach (PhysicalProductModel Prod in Cart)
            {
                Prod.ShipItem(Customer);
            }

            private static CustomerModel GetCustomer()
            {
                return new CustomerModel
                {
                    FirstName = "Tim",
                    LastName = "Corey",
                    City = "Scranton",
                    EmailAddress = "tim@IamTimCorey.com",
                    PhoneNumber = "555-1222"
                };           
            }



            private static List<PhysicalProductModel> AddSampleData()
            {
                List<PhysicalProductModel> Output = new List<PhysicalProductModel>();

                Output.Add(new PhysicalProductModel { Title = "Nerf Football"}  );
                Output.Add(new PhysicalProductModel { Title = "T-Shirt"}        );
                Output.Add(new PhysicalProductModel { Title = "Hard Drive"}     );

                return Output;
            
            
            }

        }
    }
}
