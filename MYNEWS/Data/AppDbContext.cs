using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Entities;
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
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
