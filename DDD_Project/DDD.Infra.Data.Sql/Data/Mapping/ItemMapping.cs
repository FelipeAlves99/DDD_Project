using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Infra.Data.Sql.Data.Mapping
{
    class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item")
                   .HasMany(i => i.ItemOrder)
                   .WithOne(i => i.Item);

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            builder.HasIndex(i => i.Description).IsUnique();
            builder.Property(i => i.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
