using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CategorysAndProducts
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlite("Data Source=products.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Cake" },
                new Category { CategoryId = 2, CategoryName = "Drink" },
                new Category { CategoryId = 3, CategoryName = "Main Course" }
            );
            modelBuilder.Entity<Product>().HasData(

                new Product { ProductId = 1, ProductName = "Napoleoni kook", CategoryId = 1 },
                new Product { ProductId = 2, ProductName = "Brita kook", CategoryId = 1 },
                new Product { ProductId = 3, ProductName = "Kirju koer", CategoryId = 1 },
                new Product { ProductId = 4, ProductName = "Šokolaadivahukook", CategoryId = 1 },
                new Product { ProductId = 5, ProductName = "Juustukook", CategoryId = 1 },
                new Product { ProductId = 6, ProductName = "Mee kook", CategoryId = 1 },
                new Product { ProductId = 7, ProductName = "Kohupiimakook", CategoryId = 1 },
                new Product { ProductId = 8, ProductName = "Biskviitkook", CategoryId = 1 },

                new Product { ProductId = 9, ProductName = "Piim", CategoryId = 2 },
                new Product { ProductId = 10, ProductName = "Vesi", CategoryId = 2 },
                new Product { ProductId = 11, ProductName = "Kohvi", CategoryId = 2 },
                new Product { ProductId = 12, ProductName = "Smuuti", CategoryId = 2 },
                new Product { ProductId = 13, ProductName = "Kako", CategoryId = 2 },
                new Product { ProductId = 14, ProductName = "Morss", CategoryId = 2 },
                new Product { ProductId = 15, ProductName = "Glögi", CategoryId = 2 },
                new Product { ProductId = 16, ProductName = "Õlu", CategoryId = 2 },
                new Product { ProductId = 17, ProductName = "Coca-Cola", CategoryId = 2 },
                new Product { ProductId = 18, ProductName = "Sprite", CategoryId = 2 },

                new Product { ProductId = 19, ProductName = "Pasta", CategoryId = 3 },
                new Product { ProductId = 20, ProductName = "Kana", CategoryId = 3 },
                new Product { ProductId = 21, ProductName = "Kartul", CategoryId = 3 },
                new Product { ProductId = 22, ProductName = "Kaste", CategoryId = 3 },
                new Product { ProductId = 23, ProductName = "Kala", CategoryId = 3 },
                new Product { ProductId = 24, ProductName = "Hakkliha", CategoryId = 3 },
                new Product { ProductId = 25, ProductName = "Köögivili", CategoryId = 3 },
                new Product { ProductId = 26, ProductName = "Puder", CategoryId = 3 },
                new Product { ProductId = 27, ProductName = "Supp", CategoryId = 3 },
                new Product { ProductId = 28, ProductName = "Praad", CategoryId = 3 },
                new Product { ProductId = 29, ProductName = "Magustoit", CategoryId = 3 }

            );
        }
    }
}
