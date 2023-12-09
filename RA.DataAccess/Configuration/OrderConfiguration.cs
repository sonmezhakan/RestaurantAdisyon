using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RA.Entities.Entity;

namespace RA.DataAccess.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x => x.CreatedUserId).IsRequired();
            builder.Property(x => x.TableId).IsRequired();

            builder.HasOne(x => x.CreatedUser).WithMany(x => x.Orders).HasForeignKey(x => x.CreatedUserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Table).WithMany(x => x.Orders).HasForeignKey(x => x.TableId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
