using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Context;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork db = new UnitOfWork();


            var list = db.CustomerRepository.GetAllCustomers();

            //Accounting_DBEntities db = new Accounting_DBEntities();
            //ICustomerRepository customer = new CustomerRepository(db);

            //Customers AddCustomer = new Customers()
            //{
            //    FullName = "مهرام مهرسام",
            //    CustomerImage = "NoPhoto",
            //    Mobile = "09142563698",
            //};
            //customer.InsertCustomer(AddCustomer);
            ////customer.Save();

            //var list = customer.GetAllCustomers();
        }
    }
}
