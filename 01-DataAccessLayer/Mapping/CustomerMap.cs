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
  public  class CustomerMap: EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(x => x.CompanyID);
            Property(x => x.CompanyID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnType("varchar").HasMaxLength(100);
          
            
        }

    }
}
