using DDD.Domain.Entities.CompanyEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infra.Data.Sql.Data.Mapping
{
    public class SecundaryActivityMapping : IEntityTypeConfiguration<Atividade_Secundaria>
    {
        public void Configure(EntityTypeBuilder<Atividade_Secundaria> builder)
        {
            builder.ToTable("SeundaryActivity")
                .HasOne(a => a.Company)
                .WithMany(c => c.Atividades_Secundarias)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
