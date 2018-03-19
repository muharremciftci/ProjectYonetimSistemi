using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Entity
{
   public class CustomerDemand
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string State { get; set; }
        public int CompanyID { get; set; }
        public Customer Customer { get; set; }
   
    }
}
