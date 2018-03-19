using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{
  public  class TeamBusiness
    {
        UnitOfWork _uof;
        public TeamBusiness()
        {
            _uof = new UnitOfWork();
        }
        public List<Team> GetAll()
        {
            return _uof.TeamRepository.GetAll();
        }
    }
}
