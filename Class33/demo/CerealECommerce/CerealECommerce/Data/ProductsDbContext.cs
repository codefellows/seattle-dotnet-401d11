using CerealECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerealECommerce.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(

        new Post
        {
            ID = 1,
            Title = "Hello World",
            Content = "Hello beautiful wonderful world!"
        },
        new Post
        {
            ID = 2,
            Title = "We're All Mad",
            Content = "Oh, you can’t help that,” said the Cat: “we’re all mad here. I’m mad. You’re mad.” “How do you know I’m mad?” said Alice. “You must be,” said the Cat, or you wouldn’t have come here."
        },
        new Post
        {
            ID = 3,
            Title = "Yesterday, Yesterday",
            Content = "It’s no use going back to yesterday,because I was a different person then."
        },
        new Post
        {
            ID = 4,
            Title = "Good advice",
            Content = "She generally gave herself very good advice (though she very seldom followed it)"
        }

        );

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
