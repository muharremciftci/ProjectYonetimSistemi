using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Entity
{
  public class Project
    {
      
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadLine { get; set; }
        public string State { get; set; }
        public string  Description { get; set; }

        public int TeamID { get; set; }
        public Team Team { get; set; }

        public int CompanyID { get; set; }
        public Customer Company { get; set; }
    
  }
}
