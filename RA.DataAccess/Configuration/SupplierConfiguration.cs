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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(x => x.CompanyName).HasMaxLength(250).IsRequired();
            builder.Property(x => x.ContactName).HasMaxLength(64);
            builder.Property(x => x.PhoneNumber).HasColumnType("char(11)").HasMaxLength(11).IsRequired();
            builder.Property(x => x.Adress).HasMaxLength(250).IsRequired();
            builder.Property(x=>x.CreatedUserId).IsRequired();
            builder.Property(x=>x.CreatedDate).IsRequired();
            builder.Property(x=>x.UpdatedDate).IsRequired();

            builder.HasOne(x => x.CreatedUser).WithMany(x => x.Suppliers).HasForeignKey(x => x.CreatedUserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
