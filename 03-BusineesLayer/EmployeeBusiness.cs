using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{
  public class EmployeeBusiness
  {
      UnitOfWork _uof;
      public EmployeeBusiness()
      {
          _uof = new UnitOfWork();
      }
      public bool AddEmployee(Employee emp) {
          _uof.EmployeeRepository.Add(emp);
          return _uof.ApplyChanges();
      }
      public bool UpdateEmployee(Employee emp) {
          _uof.EmployeeRepository.Update(emp);
          return _uof.ApplyChanges();
      }


      public Employee Login(string mail, string password)
      {
          if (string.IsNullOrWhiteSpace(mail)&&string.IsNullOrWhiteSpace(password))
          {
              throw new Exception("Lütfen doğru bilgiler Giriniz");
          }
      

        
             Employee result = (from emp in GetAll()
                             where emp.Email == mail && emp.Password == password
                             select emp

                                 ).FirstOrDefault();

             return result;
             
      
      }
      public List<Employee> GetAll()
      {
         return _uof.EmployeeRepository.GetAll();

      }
      public Employee Get(int id) {
          return _uof.EmployeeRepository.Get(id);
      }

  }
}
