﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RA.Entities.Entity;

namespace RA.DataAccess.Configuration
{
    public class TableConfiguration : BaseConfiguration<Table>
    {
        public override void Configure(EntityTypeBuilder<Table> builder)
        {

            builder.Property(x => x.TableName).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedUserId).IsRequired();
        }
    }
}
