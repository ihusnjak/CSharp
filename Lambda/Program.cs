using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer();
            customer1.Id = 101;
            customer1.Name = "Mark";
            customer1.Sallary = 5000;

            Customer customer2 = new Customer();
            customer2.Id = 110;
            customer2.Name = "Pam";
            customer2.Sallary = 6500;

            Customer customer3 = new Customer
            {
                Id = 119,
                Name = "John",
                Sallary = 3500
            };

        List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            Customer customer = customers.Find(c => c.Id == 101);
            Console.WriteLine($"{customer.Id} {customer.Name} {customer.Sallary}");
            
            int count = customers.Count(c => c.Sallary < 4000);
            Console.WriteLine(count);

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sallary { get; set; }

    }

}