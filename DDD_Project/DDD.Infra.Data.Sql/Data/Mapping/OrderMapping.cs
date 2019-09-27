using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infra.Data.Sql.Data.Mapping
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order")
                .HasOne(p => p.Company)
                .WithMany(c => c.Orders)
                .HasForeignKey(p => p.CompanyId);

            builder.HasMany(p => p.ItemOrder)
                .WithOne(p => p.Order);
        }
    }
}
