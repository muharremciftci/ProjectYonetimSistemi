using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Entity
{
    public class Tassk
    {
        public int ID { get; set; }
        public string Subject { get; set; }
   
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadLine { get; set; }
        public string State { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set; }


    }
}
