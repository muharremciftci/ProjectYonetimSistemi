using _00_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
    public  class UnitOfWork
    {
        TaskManagmentContext _context;
        public UnitOfWork()
        {
            _context = new TaskManagmentContext();
        }

        private PositionRepository _positionRepository;
        public PositionRepository PositionRepository
        {
            get
            {
                if (_positionRepository == null)
                {
                    _positionRepository = new PositionRepository(_context);
                }

                return _positionRepository;
            }

        }
      

        private CustomerRepository _customerRepository;
        public CustomerRepository CustomerRepository
        {
            get {
                if (_customerRepository == null)
                {
                   _customerRepository = new CustomerRepository(_context);
                }
                
                return _customerRepository; 
            }
   
        }
       
        private EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_context);
                }

                return _employeeRepository;
            }

        }

        private ProjectRepository _projectRepository;
        public ProjectRepository ProjectRepository {
            get {
                if (_projectRepository==null)
                {
                    _projectRepository = new ProjectRepository(_context);
                }
                return _projectRepository;
            
            }
        
        }


        private TasskRepository _taskRepository;
        public TasskRepository TaskRepository
        {
            get
            {
                if (_taskRepository==null)
                {
                    _taskRepository = new TasskRepository(_context);
                }
                return _taskRepository;
            }
        }

        

        private CustomerDemandRepository _customerDemandRepository;
        public CustomerDemandRepository CustomerDemandRepository
        {
            get
            {
                if (_customerDemandRepository==null)
                {
                    _customerDemandRepository = new CustomerDemandRepository(_context);
                }

                return _customerDemandRepository;
            }
        }

        private HistoryTaskRepository _historyTaskRepository;
        public HistoryTaskRepository HistoryTaskREpository
        {
            get
            {
                if (_historyTaskRepository==null)
                {
                    _historyTaskRepository = new HistoryTaskRepository(_context);
                }
                return _historyTaskRepository;
            }
        }

        private TeamRepository _teamRepository;
        public TeamRepository TeamRepository
        {
            get
            {
                if (_teamRepository==null)
                {
                    _teamRepository = new TeamRepository(_context);
                }
                return _teamRepository;
            }
        }

        public bool ApplyChanges()
        {

            DbContextTransaction _tran;
            _tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                _context.SaveChanges();
                _tran.Commit();
                return true;
            }
            catch (Exception)
            {
                _tran.Rollback();
                return false;

            }
            finally
            {
                _tran.Dispose();
            }
        }
    }
}
