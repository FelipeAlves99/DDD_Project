using DDD.Domain.Entities.CompanyEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Infra.Data.Sql.Data.Mapping
{
    public class MainActivityMapping : IEntityTypeConfiguration<Atividade_Principal>
    {
        public void Configure(EntityTypeBuilder<Atividade_Principal> builder)
        {
            builder.ToTable("AtividadePrincipal")
                .HasOne(a => a.Company)
                .WithMany(c => c.Atividade_Principal)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
