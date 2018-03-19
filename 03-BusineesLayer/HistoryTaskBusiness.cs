using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{   
   public class HistoryTaskBusiness
    {
        UnitOfWork _uof;
        public HistoryTaskBusiness()
        {
            _uof = new UnitOfWork();
        }
        public bool AddHistoryTask(HistoryTask historyTask)
        {
            _uof.HistoryTaskREpository.Add(historyTask);
            return _uof.ApplyChanges();
        }
        public bool UpdateHistoryTask(HistoryTask historyTask)
        {
            _uof.HistoryTaskREpository.Update(historyTask);
            return _uof.ApplyChanges();
        }
        public List<HistoryTask> GetMyTask(int id)
        {


            List<HistoryTask> result = (from task in _uof.HistoryTaskREpository.GetAll()
                                        where task.EmployeeID == id
                                        select task
                              ).ToList();
            return result;

        }
        public HistoryTask Get(int id) {
            return _uof.HistoryTaskREpository.Get(id);
             }
        public bool Update(HistoryTask task) {
            _uof.HistoryTaskREpository.Update(task);
            return _uof.ApplyChanges();

        }
    }
}
