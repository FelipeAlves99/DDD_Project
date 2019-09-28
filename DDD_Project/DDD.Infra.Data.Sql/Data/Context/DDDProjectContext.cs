using DDD.Domain.Entities;
using DDD.Domain.Entities.CompanyEntity;
using DDD.Infra.Data.Sql.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.Data.Sql.Data.Context
{
    public class DDDProjectContext : DbContext
    {
        AppConfiguration appConfiguration = new AppConfiguration();

        public DDDProjectContext() : base()
        { }

        public DDDProjectContext(DbContextOptions<DDDProjectContext> options) : base(options)
        { }

        #region DbSet's

        public DbSet<Company> Companies { get; set; }
        public DbSet<Atividade_Principal> MainActivities { get; set; }
        public DbSet<Atividade_Secundaria> SecundaryActivities { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ForSqlServerUseIdentityColumns();

            #region Mapping

            modelBuilder.Entity<Company>(new CompanyMapping().Configure);
            modelBuilder.Entity<Atividade_Principal>(new MainActivityMapping().Configure);
            modelBuilder.Entity<Atividade_Secundaria>(new SecundaryActivityMapping().Configure);
            modelBuilder.Entity<Item>(new ItemMapping().Configure);
            modelBuilder.Entity<Order>(new OrderMapping().Configure);
            modelBuilder.Entity<ItemOrder>(new ItemOrderMapping().Configure);

            #endregion

        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(appConfiguration.ConnectionString);
        }

    }
}
