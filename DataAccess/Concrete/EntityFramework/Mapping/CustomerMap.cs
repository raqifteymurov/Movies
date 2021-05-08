using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customers");
            HasKey(p => p.Id);
            Property(p => p.FirstName).HasColumnName("FirstName");
            Property(p => p.LastName).HasColumnName("LastName");
            Property(p => p.Age).HasColumnName("Age");
            Property(p => p.ChosenMovie).HasColumnName("ChosenMovie");

        }

    }
}
