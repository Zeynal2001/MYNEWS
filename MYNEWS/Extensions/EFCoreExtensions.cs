using Microsoft.EntityFrameworkCore;
using MYNEWS.Entities;
using System.Runtime.CompilerServices;

namespace MYNEWS.Extensions
{
    public static class EFCoreExtensions
    {
        public static void SeedNews(this ModelBuilder modelBuilder)
        {
            List<News> news = new List<News>()
            {
                new News()
                {
                    Id = Guid.NewGuid(),
                    Title = "Medicine can now put a stop to cancer",
                    Content = "Now it's possible. How? Let's dive in:",
                    PhotoPathForTrending = "img/news-100x100-1.jpg",
                    CreatedAt = DateTime.UtcNow,
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Title = "How can you increase your efficiency in your business?",
                    Content = "This is easy",
                    PhotoPathForTrending = "img/news-100x100-2.jpg",
                    CreatedAt = DateTime.UtcNow,
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Title = "The best technological products released this year?",
                    Content = "Here in this article, we have listed them for you. Continue:",
                    PhotoPathForTrending = "img/news-100x100-3.jpg",
                    CreatedAt = DateTime.UtcNow,
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Title = "Why are women usually afraid of guns?",
                    Content = "Research on this has ended. Here are the main reasons:",
                    PhotoPathForTrending = "img/news-100x100-5.jpg",
                    CreatedAt = DateTime.UtcNow,
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Title = "Important development for kindergartens",
                    Content = "The Ministry of Education announced its decision:",
                    PhotoPathSingleBig = "img/news-700x435-1.jpg",
                    CreatedAt = DateTime.UtcNow,
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Title = "Effective Training Techniques for Optimal Results",
                    Content = "Are you ready to take your bodybuilding journey to the next level? Achieving optimal results in bodybuilding requires more than just lifting weights aimlessly. It demands a strategic approach, incorporating effective training techniques tailored to your goals and body type. Here are some key strategies to help you maximize your workouts and achieve the gains you desire:\r\n\r\n1. *Progressive Overload:* One of the fundamental principles of bodybuilding is progressive overload. This involves gradually increasing the stress placed on your muscles over time to stimulate growth. Whether it's adding more weight to your lifts, increasing the number of reps, or shortening rest periods between sets, consistently challenging your muscles is essential for continual progress. 2. *Compound Movements:* Focus on compound exercises that target multiple muscle groups simultaneously, such as squats, deadlifts, bench presses, and pull-ups. These compound movements not only build strength and muscle mass more efficiently but also engage stabilizing muscles, enhancing overall muscle development and functional strength.",
                    PhotoPathSingleBig = "img/Jerry Ossi_992401984_o.jpg",
                    PhotoPathForCategories = "img/Jerry Ossi_992401984_o.jpg",
                    CreatedAt = DateTime.UtcNow,
                },
            };

            modelBuilder.Entity<News>()
                .HasData(news);
        }



        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id= Guid.NewGuid(),
                    CategoryName = "Health",
                    CreatedAt = DateTime.UtcNow
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    CategoryName = "Business",
                    CreatedAt = DateTime.UtcNow,
                    LongPhotoPathForCategories = "img/cat-500x80-1.jpg"
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    CategoryName = "Technology",
                    CreatedAt = DateTime.UtcNow,
                    LongPhotoPathForCategories = "img/cat-500x80-2.jpg"
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    CategoryName = "Society and Culture",
                    CreatedAt = DateTime.UtcNow
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    CategoryName = "Education",
                    CreatedAt = DateTime.UtcNow
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    CategoryName = "Sport",
                    CreatedAt = DateTime.UtcNow,
                    LongPhotoPathForCategories = "img/cat-500x80-4.jpg"
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    CategoryName = "Entertainment",
                    CreatedAt = DateTime.UtcNow,
                    LongPhotoPathForCategories = "img/cat-500x80-3.jpg"
                },
            };

            modelBuilder.Entity<Category>()
                .HasData(categories);
        }




        public static void SeedSubcategories(this ModelBuilder modelBuilder)
        {
            List<Subcategory> subcategories = new List<Subcategory>()
            {
                new Subcategory()
                {
                    Id = Guid.NewGuid(),
                    SubcategoryName = "Medical and Health News",
                    CreatedAt= DateTime.UtcNow
                },
                new Subcategory()
                {
                    Id = Guid.NewGuid(),
                    SubcategoryName = "Strategic Management and Planning",
                    CreatedAt= DateTime.UtcNow
                },
                new Subcategory()
                {
                    Id = Guid.NewGuid(),
                    SubcategoryName = "Information Technology and Information Systems",
                    CreatedAt= DateTime.UtcNow
                },
                new Subcategory()
                {
                    Id = Guid.NewGuid(),
                    SubcategoryName = "Gender and Analysis of Gender Roles in Society",
                    CreatedAt= DateTime.UtcNow,
                },
                new Subcategory()
                {
                    Id = Guid.NewGuid(),
                    SubcategoryName = "Schools and Educational Institutions",
                    CreatedAt= DateTime.UtcNow
                },

            };

            modelBuilder.Entity<Subcategory>()
                .HasData(subcategories);
        }





        public static void SeedTags(this ModelBuilder modelBuilder)
        {
            List<NewsTag> tags = new List<NewsTag>()
            {
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Health",
                    CreatedAt = DateTime.UtcNow,
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#MedicalAdvancements",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#CancerResearch",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#TreatmentOptions",
                    CreatedAt = DateTime.UtcNow
                },
                //------------------------------------------
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Efficiency",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#BusinessTips",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Productivity",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#StrategicManagement",
                    CreatedAt = DateTime.UtcNow
                },
                //------------------------------------------
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Technology",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#TechProducts",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Innovation",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#TechTrends",
                    CreatedAt = DateTime.UtcNow
                },
                //-------------------------------------------
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#GenderRoles",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#GunSafety",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Women",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#SocietalFear",
                    CreatedAt = DateTime.UtcNow
                },
                //-------------------------------------------
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Education",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#Kindergarten",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#ChildDevelopment",
                    CreatedAt = DateTime.UtcNow
                },
                new NewsTag()
                {
                    Id= Guid.NewGuid(),
                    TagName = "#EarlyEducation",
                    CreatedAt = DateTime.UtcNow
                },
                //-------------------------------------------

            };

            modelBuilder.Entity<NewsTag>()
                .HasData(tags);

            /*
             "Medicine can now put a stop to cancer":

             #Health
             #MedicalAdvancements
             #CancerResearch
             #TreatmentOptions

             "How can you increase your efficiency in your business?":

             #Efficiency
             #BusinessTips
             #Productivity
             #StrategicManagement

             "The best technological products released this year?":

             #Technology
             #TechProducts
             #Innovation
             #TechTrends

             "Why are women usually afraid of guns?":

             #GenderRoles
             #GunSafety
             #Women
             #SocietalFear

             "Important development for kindergartens":

             #Education
             #Kindergarten
             #ChildDevelopment
             #EarlyEducation
            */
        }
    }
}
