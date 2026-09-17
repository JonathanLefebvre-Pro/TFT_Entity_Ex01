using Ex01.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ex01.Context
{
    internal class ExContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<Shop> Shops { get; set; }
        //public DbSet<Invoice> Invoices { get; set; }
        //public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=JONATHAN\DATAVIZ;" +
                              "Database=EntityEx01;" +
                              "Trusted_Connection=True;" +
                              "TrustServerCertificate=True;");
        }

        //Commands
        //dotnet tool install --global dotnet-ef --version 10.0.12
        //dotnet tool install --local dotnet-ef --version 10.0.12
        //dotnet ef migrations add initUserEntity --project Ex01
        //dotnet ef database update --project Ex01

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Type = RoleType.admin },
                new Role() { Id = 2, Type = RoleType.user }
                );
        }
    }
}
