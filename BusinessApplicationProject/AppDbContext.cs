using BusinessApplicationProject.Model;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject
{
    public class AppDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleGroup> ArticleGroups { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BusinessApplicationProjectDb;User Id=businessapplicationproject_client;Password=Password123;Encrypt=no");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>().ToTable(nameof(Addresses), b => b.IsTemporal());
            modelBuilder.Entity<Article>().ToTable(nameof(Articles), b => b.IsTemporal());

            //DataSeeder.InsertSeedData(this);
        }
    }
}
