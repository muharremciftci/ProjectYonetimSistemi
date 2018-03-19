using _00_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
   public class PositionRepository:BaseRepository<Position>
    {
       public PositionRepository(TaskManagmentContext context):base(context)
       {

       }
    }
}
