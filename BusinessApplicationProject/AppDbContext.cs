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

            #region Configure PKs

            modelBuilder.Entity<Address>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Article>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ArticleGroup>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Invoice>()
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
                .Property (o => o.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Position>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            #endregion

            #region Configure Navigation Properties

            modelBuilder.Entity<Article>()
                .HasOne(a => a.Group)
                .WithMany()
                .HasForeignKey(g => g.Id)
                .IsRequired(false);

            modelBuilder.Entity<ArticleGroup>()
                .HasOne(a => a.Parent)
                .WithMany()
                .HasForeignKey(p => p.Id)
                .IsRequired(false);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.CustomerAddress)
                .WithMany()
                .HasForeignKey(a => a.Id);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.BillingAddress)
                .WithMany()
                .HasForeignKey(b => b.Id);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.OrderInformations)
                .WithMany()
                .HasForeignKey(o => o.Id);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.CustomerDetails)
                .WithMany()
                .HasForeignKey(c => c.Id);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Positions)
                .WithOne()
                .HasForeignKey(p => p.Id);

            modelBuilder.Entity<Position>()
                .HasOne(p => p.ArticleDetails)
                .WithMany()
                .HasForeignKey(a => a.Id);

            #endregion

            modelBuilder.Entity<Address>().ToTable(nameof(Addresses), b => b.IsTemporal());
            modelBuilder.Entity<Article>().ToTable(nameof(Articles), b => b.IsTemporal());

            DataSeeder.InsertSeedData(this);
        }
    }
}
