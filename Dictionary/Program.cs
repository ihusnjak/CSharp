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

            Customer customer3 = new Customer();
            customer3.Id = 119;
            customer3.Name = "John";
            customer3.Sallary = 3500;   

            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
            customerDictionary.Add(customer1.Id, customer1);
            customerDictionary.Add(customer2.Id, customer2);
            customerDictionary.Add(customer3.Id, customer3);

            var customer119 = customerDictionary[119];
            Console.WriteLine($"ID = {customer119.Id}, Name = {customer119.Name}, Sallary = {customer119.Sallary} ");

            //loop with KeyValue -> can use "var" instead "KeyValuePair<int, Customer> "
            foreach (KeyValuePair<int, Customer> kvp in customerDictionary)
            {
                Console.WriteLine($"Key = {kvp.Key}");
                var customer = kvp.Value;
                Console.WriteLine($"ID = {customer.Id}, Name = {customer.Name}, Sallary = {customer.Sallary}");
            }

            //TryGetValue returns boolean
            Customer customerTryGetValue;
            if (customerDictionary.TryGetValue(119, out customerTryGetValue))
            {
                Console.WriteLine($"ID = {customerTryGetValue.Id}, Name = {customerTryGetValue.Name}, Sallary = {customerTryGetValue.Sallary}");
            } else
            {
                Console.WriteLine("Key not found!");
            }

            //also can  use Linq .Count() method
            Console.WriteLine($"Total in dictionary is = {customerDictionary.Count}");
            //with .Count()
            Console.WriteLine($"Total in dictionary is = {customerDictionary.Count(kvp => kvp.Value.Sallary > 4000)}");

            // Remove 1 item from dictionary by Key , use Clear() to remove all items in dictionary
            customerDictionary.Remove(customer1.Id);
            Console.WriteLine($"Total in dictionary is = {customerDictionary.Count}");

            //convert Array to Dictionary
            Customer[] customersArray = new Customer[3];
            customersArray[0] = customer1;
            customersArray[1] = customer2;
            customersArray[2] = customer3;

            var dictionaryFromArray = customersArray.ToDictionary(c => c.Id, c => c);
            foreach (var kvp in customerDictionary)
            {
                Console.WriteLine($"Key = {kvp.Key}");
                var customer = kvp.Value;
                Console.WriteLine($"ID = {customer.Id}, Name = {customer.Name}, Sallary = {customer.Sallary}");
            }

        }

    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sallary { get; set; }

    }

}