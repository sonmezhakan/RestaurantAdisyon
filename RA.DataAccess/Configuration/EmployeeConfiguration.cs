using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.DataAccess.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Ignore(x => x.CreatedUserId);

            builder.Property(x => x.FirstName).HasMaxLength(64).IsRequired();
            builder.Property(x=>x.LastName).HasMaxLength(64).IsRequired();
            builder.Property(x=>x.Email).HasMaxLength(128).IsRequired();
            builder.Property(x=>x.Adress).HasMaxLength(250).IsRequired();
            builder.Property(x=>x.PhoneNumber).HasColumnType("char(11)").IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x=>x.UpdatedDate).IsRequired();
        }
    }
}
