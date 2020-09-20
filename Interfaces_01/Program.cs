using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Interfaces_01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IProductModel> Cart = AddSampleData();

            CustomerModel Customer = GetCustomer();
            
            foreach (IProductModel Prod in Cart)
            {               
                Prod.ShipItem(Customer);

                if (Prod is IDigitalProductModel Digital)       // is works as in SQL Server
                {

                    Console.WriteLine($"For the {Digital.Title} there are {Digital.TotalDownloadsLeft} downloads left");
                
                }
            }

            static CustomerModel GetCustomer()
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

            static List<IProductModel> AddSampleData()
            {
                List<IProductModel> Output = new List<IProductModel>();

                Output.Add(new PhysicalProductModel { Title = "Nerf Football"}          );
                Output.Add(new PhysicalProductModel { Title = "T-Shirt"}                );
                Output.Add(new PhysicalProductModel { Title = "Hard Drive"}             );
                Output.Add(new DigitalProductModel  { Title = "E-book" }                );
                Output.Add(new CourseProductModel   { Title = ".Net Core 0 to hero" }   );

                return Output;
             
            }

        }
    }
}
