using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> o) : base(o)
        {

        }
        public DbSet<Category> Categories { get; set; }
        //ModelBuilder you can see the data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //lenh tao cac gia tri cho moi hang cua bang
            //.Entity<ten thuc the>.hasdate mot mang cua thuc the do
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, DisplayOrder = 1, Name = "Tam ly hoc" },
                new Category { Id = 2, DisplayOrder = 2, Name = "Truven" },
                new Category { Id = 3, DisplayOrder = 3, Name = "Hai" });
        }
    }
}
