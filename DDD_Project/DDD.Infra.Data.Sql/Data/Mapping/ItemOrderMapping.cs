using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Infra.Data.Sql.Data.Mapping
{
    public class ItemOrderMapping : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.ToTable("ItemOrder")
                .HasKey(table => new
                {
                    table.OrderId,
                    table.ItemId
                });
        }
    }
}
