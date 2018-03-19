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
    public class TaskMap : EntityTypeConfiguration<Tassk>
    {
        public TaskMap()
        {
            HasKey(x => x.ID);
           
            Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectID).IsRequired();
            Property(x => x.State).HasColumnType("varchar").HasMaxLength(20);

            HasRequired(x=>x.Project)
                .WithMany()
                .HasForeignKey(x=>x.ProjectID);

       
        }
    }
}
