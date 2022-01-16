using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() 
            {Id=1,FirstName="Çağıl",LastName="Alsaç" };
            Console.WriteLine("ID: "+person1.Id+" Adı: "+person1.FirstName+" Soyad: "+person1.LastName);

            IPerson person2 = new Person() 
            {Id=2,FirstName="Leo",LastName="ALsaç" };
            Console.WriteLine("ID: " + person2.Id + " Adı: " + person2.FirstName + " Soyad: " + person2.LastName);

            Customer customer1 = new Customer()
            { Id = 3, FirstName = "X", LastName = "Y", Address = "Ankara" };

            Customer customer2 = new Customer();
            customer2.Id = 4;
            customer2.FirstName = "X";
            customer2.LastName = "Y";
            customer2.Address = "New York";

            IPerson customer3 = new Customer();
            customer3.Id = 5;
            customer3.FirstName = "X";
            customer3.LastName = "Y";

            IPerson customer4 = new Customer()
            { Id = 6, FirstName = "X", LastName = "Y", Address = "İstanbul" };

            //Customer customer44 = (Customer)customer4;    (Casting)
            Customer customer44 = customer4 as Customer; // ("as"Casting)
            Console.WriteLine($"ID: { customer44.Id} Adı: {customer44.FirstName} Soyad: {customer44.LastName} Adres: {customer44.Address}");

            Console.ReadLine();
        }
    }
    #region Interface (IPerson)
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    #endregion
    #region 1.Class (Person)
    class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    #endregion
    #region 2.Class (Customer)
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    #endregion
    #region 3.Class (Student)
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    #endregion
}
