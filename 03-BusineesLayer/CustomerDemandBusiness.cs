using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{
   public class CustomerDemandBusiness
    {
        UnitOfWork _uof;
        public CustomerDemandBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool AddCustomerDemand (CustomerDemand customerDemand)
        {
            _uof.CustomerDemandRepository.Add(customerDemand);
            return _uof.ApplyChanges();
        }
        public List<CustomerDemand> GetAll()
        {
            return _uof.CustomerDemandRepository.GetAll();
        }

    }
}
