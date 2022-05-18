using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Chanel", Url = "chanel"},
                new Category { Id = 2, Name = "Gucci", Url = "gucci"},
                new Category { Id = 3, Name = "Dior", Url = "dior"},
                new Category { Id = 4, Name = "LouisVuitton", Url = "louisvuitton" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Bled de CHANEL",
                    Description = "BLEU DE CHANEL khẳng định bản lĩnh hoàn hảo thông qua một mùi hương bất ngờ và vượt thời gian. Hương thơm hương gỗ tỏa ra thành một đường mòn quyến rũ, thể hiện sự độc lập với sức mạnh và sự sang trọng, giống như người đàn ông mang nó.",
                    Concenstration = "Parfum",
                    Capacity = 100,
                    Price = 3100000,
                    Image = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_620/bleu-de-chanel-eau-de-toilette-spray-3-4fl-oz--packshot-default-107460-8848377315358.jpg",
                    
                }
                
            );
            
        }
    }
}
