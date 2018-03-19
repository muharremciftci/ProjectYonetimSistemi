using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{
   public class PositionBusiness
    {
       UnitOfWork _uof;
       public PositionBusiness()
       {
           _uof = new UnitOfWork();
       }
       public List<Position> GetAll()
       {
           return _uof.PositionRepository.GetAll();
       }

    }
}
