using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{
   public class CustomerBusiness
   {
       UnitOfWork _uof;
       public CustomerBusiness()
       {
           _uof = new UnitOfWork();
       }
       public bool AddCustomer(Customer customer) {
           _uof.CustomerRepository.Add(customer);
           return _uof.ApplyChanges();


       }

       public List<Customer> GetAllCustomer() {
           return _uof.CustomerRepository.GetAll();
       }







    }
}
