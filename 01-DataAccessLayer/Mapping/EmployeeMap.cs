using _00_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.Mapping
{
   public class EmployeeMap:EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(x => x.ID);
          
            Property(x => x.FirstName).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.LastName).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.TeamID).IsOptional();
       
            HasOptional(x => x.Team).WithMany().HasForeignKey(x => x.TeamID);
            HasRequired(x => x.Position).WithMany().HasForeignKey(x => x.PositionID);
            Property(x => x.Email).IsRequired().HasColumnType("varchar").HasMaxLength(100);













        }
    }
}
