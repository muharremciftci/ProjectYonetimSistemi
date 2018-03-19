using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Entity
{
   public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
           
        
        public string Description { get; set; }
       
      
        public ICollection<Project> Project { get; set; }



    }
}
