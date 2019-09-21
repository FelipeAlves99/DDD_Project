using DDD.Domain.Entities;
using DDD.Domain.Entities.CompanyEntity;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.Data.Sql.Data.Context
{
    public class DDDProjectContext : DbContext
    {
        public DDDProjectContext() : base()
        { }

        public DDDProjectContext(DbContextOptions<DDDProjectContext> options) : base(options)
        { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Atividade_Principal> MainActivities { get; set; }
        public DbSet<Atividade_Secundaria> SecundaryActivities { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ForSqlServerUseIdentityColumns();

            //mapping

        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("ConnectionString");
        }

    }
}
