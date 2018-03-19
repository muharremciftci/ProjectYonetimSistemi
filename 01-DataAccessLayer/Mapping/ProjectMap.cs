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
    public class ProjectMap:EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            HasKey(x=>x.ID);
            Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnType("varchar").HasMaxLength(1000);
            Property(x => x.State).HasColumnType("varchar").HasMaxLength(1000);
               
        }
    }
}
