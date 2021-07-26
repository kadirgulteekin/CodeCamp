using System;

namespace Consructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Kadir", LastName = "Gültekin", City = "İstanbul" };   //bu bir parametre değil!!

            Customer customer3 = new Customer();
            customer3.Id = 1;   //Üstteki kullanıma eşittir.



            Customer customer = new Customer(2,"Kadir","sfsdf","sdfsdfs");
            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)   
        {
            //Bir sınıfı new'lediğimizde çalışmasını istediğimiz kodlar varsa onları consructor içerisine koyuyoruz.

            //Değerleri set ettik
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
