using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person();

            person.FirstName = "Kadir";
            person1 = person;
            person.FirstName = "Burak";
            Console.WriteLine(person1.FirstName);
            Customer customer = new Customer();
            customer.CustomerNumber = 46546;
            
            customer.FirstName = "Elanur";
            Console.WriteLine(customer.FirstName);
            Employee employee = new Employee();
            employee.FirstName = "Veli";


            Person person2 = customer;    //Person customer'inda emplpyee'inde adresini tutuyor.
           
            Console.WriteLine(((Customer)person2).CustomerNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);



            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Employee : Person
    {
        public int CreditNumber { get; set; }
    }

    class Customer : Person
    {
        public int CustomerNumber { get; set; }
    }

    class PersonManager
    {
       public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
