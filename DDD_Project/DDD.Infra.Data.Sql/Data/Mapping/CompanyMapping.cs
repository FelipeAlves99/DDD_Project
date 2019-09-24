using DDD.Domain.Entities.CompanyEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infra.Data.Sql.Data.Mapping
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");

            builder.HasKey(c => c.Id).HasName("Id");
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.HasIndex(c => c.Cnpj).IsUnique();
            builder.Property(c => c.Cnpj)
                .IsRequired()
                .HasMaxLength(14);

            builder.HasIndex(c => c.Nome).IsUnique();
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Uf).IsRequired();
        }
    }
}
