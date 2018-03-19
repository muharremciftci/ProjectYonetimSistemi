using _00_Entity;
using _01_DataAccessLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
     public  class TaskManagmentContext:DbContext
    {
         public TaskManagmentContext()
             : base("TaskManagment")
         {
                
         }
         public DbSet<Tassk> Tasks { get; set; }
         
         public DbSet<Customer> Customers { get; set; }
         public DbSet<CustomerDemand> CustomerDemands { get; set; }
         public DbSet<Employee> Employees { get; set; }
         public DbSet<HistoryTask> HistoryTasks{ get; set; }
         public DbSet<Position> Pozitions { get; set; }
         public DbSet<Project> Projects { get; set; }
         public DbSet<Team> Teams { get; set; }
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
         
             modelBuilder.Configurations.Add(new CustomerDemandMap());
             modelBuilder.Configurations.Add(new CustomerMap());
             modelBuilder.Configurations.Add(new EmployeeMap());
             modelBuilder.Configurations.Add(new HistoryTaskMap());
             modelBuilder.Configurations.Add(new ProjectMap());
             modelBuilder.Configurations.Add(new TaskMap());
             modelBuilder.Configurations.Add(new TeamMap());
    

             base.OnModelCreating(modelBuilder);
         }
         










    }
}
