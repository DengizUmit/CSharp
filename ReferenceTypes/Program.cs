using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Ümit";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Asil";
            customer.CreditCardNumber = 1234567890;

            Employee employee = new Employee();
            employee.FirstName = "Merve";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            //Console.WriteLine("\n" + ((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);



            Console.ReadLine();
        }

        private static void NewMethod()
        {
            //int, decimal, float, enum, boolean  --> Value Types
            int number1 = 12;
            int number2 = 20;

            number1 = number2;
            number2 = 100;

            Console.WriteLine(number1);


            // arrays, class, interface ...  --> Reference Types
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };

            numbers1 = numbers2;
            numbers2[0] = 100;

            Console.WriteLine(numbers1[0]);
        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // base class : Person
    class Customer : Person
    {
        public int CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("\n" + person.FirstName);
        }
    }
}
