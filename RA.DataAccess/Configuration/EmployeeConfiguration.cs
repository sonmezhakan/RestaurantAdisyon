using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RA.Entities.Entity;

namespace RA.DataAccess.Configuration
{
    public class EmployeeConfiguration : BaseConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Ignore(x => x.CreatedUserId);

            builder.Property(x => x.FirstName).HasMaxLength(64).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Adress).HasMaxLength(250).IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnType("char(11)").IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
        }
    }
}
