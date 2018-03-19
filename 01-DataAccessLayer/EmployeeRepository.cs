using _00_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
   public  class EmployeeRepository:BaseRepository<Employee>
   {
       TaskManagmentContext _context;
       public EmployeeRepository(TaskManagmentContext context):base(context)
       {
           _context = context;
       }
       public Employee Login(string mail, string password)
       {
           if (string.IsNullOrWhiteSpace(mail) && string.IsNullOrWhiteSpace(password))
           {
               throw new Exception("Lütfen doğru bilgiler Giriniz");
           }



           var result = (from emp in GetAll()
                         where emp.Email == mail && emp.Password == password
                         select emp

                                  ).ToList();

           if (result == null)
           {
               throw new Exception("Böyle kullanıcı Bulunamadı ");

           }
           else
           {
               return result.FirstOrDefault();
           }

       }
    }
}
