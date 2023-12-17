using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RA.Entities.Entity;

namespace RA.DataAccess.Configuration
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.Property(x => x.ProductID).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.Quantity).HasColumnType("smallint").IsRequired();
            builder.Property(x => x.UnitPrice).HasColumnType("money").IsRequired();
            builder.Property(x => x.OrderID).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductID);
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderID);

        }
    }
}
