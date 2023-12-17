using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RA.Entities.Entity;

namespace RA.DataAccess.Configuration
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Ignore(x => x.CreatedUserId);

            builder.Property(x => x.UserName).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(64).IsRequired();
            builder.Property(x => x.EmployeeID).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();


            builder.HasOne(x => x.Employee).WithMany(x => x.User).HasForeignKey(x => x.EmployeeID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
