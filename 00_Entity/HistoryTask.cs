using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Entity
{
    public class HistoryTask
    {
        public int ID { get; set; }
        public string Description { get; set; }


        public DateTime? StartDate { get; set; }
        public DateTime? DeadLine { get; set; }
        public int TasskID { get; set; }
        public Tassk Tassk { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

    }
}
