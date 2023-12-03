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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x=>x.ProductName).HasMaxLength(250).IsRequired();
            builder.Property(x=>x.UnitPrice).HasColumnType("money").IsRequired();
            builder.Property(x => x.UnitsInStock).IsRequired();
            builder.Property(x => x.CreatedUserId).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x=>x.UpdatedDate).IsRequired();
            builder.Property(x=>x.CategoryID).IsRequired();
            builder.Property(x => x.Champaing).HasColumnType("smallint");

            builder.HasOne(x => x.CreatedUser).WithMany(x => x.Products).HasForeignKey(x => x.CreatedUserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x=>x.Category).WithMany(x=>x.Products).HasForeignKey(x=>x.CategoryID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
