using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDevam
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = new CustomerService(); // new StudentService();
            service.Add();
            service.List();

            Console.ReadLine();
        }
    }
    #region Interface (IService)
    interface IService 
    {
        void Add();
        void List(); 
    }
    #endregion
    #region 1.Class (CustomerService)
    class CustomerService : IService
    {
        public void Add()
        {
            Console.WriteLine("Customer added to DB");
        }

        public void List()
        {
            Console.WriteLine("Customers listed from DB");
        }
        public void Shop() 
        {
            Console.WriteLine("Customer shopped");
        }
    }
    #endregion
    #region 2.Class (StudentService)
    class StudentService : IService
    {
        public void Add()
        {
            Console.WriteLine("Student added to DB");
        }

        public void List()
        {
            Console.WriteLine("Students listed from DB");
        }
    }
    #endregion
}
