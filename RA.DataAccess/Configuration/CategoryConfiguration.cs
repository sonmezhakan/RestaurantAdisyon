﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.DataAccess.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Desription).HasMaxLength(250);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x=>x.CreatedUserId).IsRequired();
            builder.Property(x => x.Champaing).HasColumnType("smallint");

            builder.HasOne(x => x.CreatedUser).WithMany(x => x.Categories).HasForeignKey(x => x.CreatedUserId);
        }
    }
}