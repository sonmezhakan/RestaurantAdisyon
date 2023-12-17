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
    public class StockConfiguration : BaseConfiguration<Stock>
    {
        public override void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(x => x.ProductID).IsRequired();
            builder.Property(x => x.SupplierID).IsRequired();
            builder.Property(x => x.UnitPrice).HasColumnType("money").IsRequired();
            builder.Property(x => x.UnitsInStock).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedUserId).IsRequired();

            builder.HasOne(x => x.CreatedUser).WithMany(x => x.Stocks).HasForeignKey(x => x.CreatedUserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Product).WithMany(x => x.Stocks).HasForeignKey(x => x.ProductID).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(x => x.Supplier).WithMany(x => x.Stocks).HasForeignKey(x => x.SupplierID).OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
