using DCartAPI.Models.Carts;
using DCartAPI.Models.Orders;
using DCartAPI.Models.Products;
using DCartAPI.Models.Users;
using Microsoft.EntityFrameworkCore;


namespace DCartAPI.Data
{
    public class DCartAPIContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DCartAPI");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Apply configurations for MainCategory,SubCategory and Products to be seeded to database
            modelBuilder.ApplyConfiguration(new MainCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}

