using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 10;
            customer1.FirstName = "Deniz";
            customer1.LastName = "Defne";
            customer1.City = "Adana";


            Customer customer2 = new Customer(2, "Barış", "Yeni", "Sivas");

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    class Customer
    {
        // default constructor
        public Customer()
        {
            // Console.WriteLine("Yapıcı Block çalıştı");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
