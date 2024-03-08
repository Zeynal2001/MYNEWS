using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Entities;
using MYNEWS.Extensions;
using System.Collections.Generic;

namespace MYNEWS.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options)
        //    : base(options)
        //{
        //}

        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<NewsTag> NewsTags { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .HasIndex(n => n.Title)
                .IsUnique(true);

            modelBuilder.SeedNews();
            modelBuilder.SeedCategories();
            modelBuilder.SeedSubcategories();
            modelBuilder.SeedTags();

            base.OnModelCreating(modelBuilder);
        }
    }
}
