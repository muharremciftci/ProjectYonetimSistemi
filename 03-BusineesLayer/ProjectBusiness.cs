using _00_Entity;
using _01_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BusineesLayer
{
    public class ProjectBusiness
    {
        UnitOfWork _uof;
        public ProjectBusiness()
        {
            _uof = new UnitOfWork();
        }
        public bool OpenProject(Project proje) {
            if (proje.CompanyID == 0)
                return false;



            _uof.ProjectRepository.Add(proje);

            return _uof.ApplyChanges();
        }
        public bool CloseProject(Project proje) {
            _uof.ProjectRepository.Delete(proje);
            return _uof.ApplyChanges();
        }
        public List<Project> GetAll() {
            return _uof.ProjectRepository.GetAll();
        }
        public Project Get(int id)
        {
            return _uof.ProjectRepository.Get(id);

        }








    }
}
