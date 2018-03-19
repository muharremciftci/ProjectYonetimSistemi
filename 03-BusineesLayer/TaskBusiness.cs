using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{
  public  class TaskBusiness
    {
        UnitOfWork _uof;
        public TaskBusiness()
        {
            _uof = new UnitOfWork();
        }
        public bool AddTask(Tassk task)
        {
            _uof.TaskRepository.Add(task);
            return _uof.ApplyChanges();
        }
        public bool TaskOfEmployee(Tassk task)
        {
            _uof.TaskRepository.Update(task);
            return _uof.ApplyChanges();
        }
        public bool StatusOfTask(Tassk task)
        {
            _uof.TaskRepository.Update(task);
            return _uof.ApplyChanges();
        }

        public List<Tassk> GetAll()
        {
            return _uof.TaskRepository.GetAll();

        }
    }
}
