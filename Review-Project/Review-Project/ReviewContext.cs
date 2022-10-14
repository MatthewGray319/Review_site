using Microsoft.EntityFrameworkCore;
using Review_Project.Models;

namespace Review_Project
{
    public class ReviewContext : DbContext
    {
        public DbSet<ReviewModel>? Reviews {get; set;}
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReviewDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Sunoco", Description = "Gasoline" });
            model.Entity<ReviewModel>().HasData(
                new ReviewModel() { Id = 1, Name = "Elon Musk", Content = "Horrible Product.", ProductId = 1 });
            base.OnModelCreating(model);
        }
    }

}
