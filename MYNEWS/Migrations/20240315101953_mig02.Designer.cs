﻿// <auto-generated />
using System;
using MYNEWS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MYNEWS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240315101953_mig02")]
    partial class mig02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorNews", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NewsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorsId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("AuthorNews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MYNEWS.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MYNEWS.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MYNEWS.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LongPhotoPathForCategories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d36a91fc-a7de-4aa7-8933-774c4ccc9ba1"),
                            CategoryName = "Health",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1202),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("662a8f20-a711-40cf-b90f-19c872fb6d78"),
                            CategoryName = "Business",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1230),
                            IsDeleted = false,
                            LongPhotoPathForCategories = "img/cat-500x80-1.jpg"
                        },
                        new
                        {
                            Id = new Guid("4cb1560f-55dd-4448-a402-b1629c04126b"),
                            CategoryName = "Technology",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1233),
                            IsDeleted = false,
                            LongPhotoPathForCategories = "img/cat-500x80-2.jpg"
                        },
                        new
                        {
                            Id = new Guid("16dff4d7-d391-4283-b499-83de67367d04"),
                            CategoryName = "Society and Culture",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1235),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("9d503f11-b843-4aea-84ec-f35f0471e457"),
                            CategoryName = "Education",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1237),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("0aa3390e-0efa-4b9c-b5f4-cf0a2ab22de7"),
                            CategoryName = "Sport",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1240),
                            IsDeleted = false,
                            LongPhotoPathForCategories = "img/cat-500x80-4.jpg"
                        },
                        new
                        {
                            Id = new Guid("ae6a7abc-ba9d-496c-8de6-19e6e26c214a"),
                            CategoryName = "Entertainment",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1243),
                            IsDeleted = false,
                            LongPhotoPathForCategories = "img/cat-500x80-3.jpg"
                        });
                });

            modelBuilder.Entity("MYNEWS.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("NewsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Vote")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("NewsId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MYNEWS.Entities.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LongPhotoPathForCategories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPathForCategories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPathForFeatured")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPathForTrending")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPathForUserComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPathSingleBig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SubcategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubcategoryId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = new Guid("329d3571-8f1b-4e06-840b-b4fa894817e2"),
                            Content = "Now it's possible. How? Let's dive in:",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(978),
                            IsDeleted = false,
                            PhotoPathForTrending = "img/news-100x100-1.jpg",
                            Title = "Medicine can now put a stop to cancer"
                        },
                        new
                        {
                            Id = new Guid("77b8afa3-0763-4361-ba4f-0306ec4d4873"),
                            Content = "This is easy",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1098),
                            IsDeleted = false,
                            PhotoPathForTrending = "img/news-100x100-2.jpg",
                            Title = "How can you increase your efficiency in your business?"
                        },
                        new
                        {
                            Id = new Guid("cb9ce477-e66d-452a-a669-61188d2d2c36"),
                            Content = "Here in this article, we have listed them for you. Continue:",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1101),
                            IsDeleted = false,
                            PhotoPathForTrending = "img/news-100x100-3.jpg",
                            Title = "The best technological products released this year?"
                        },
                        new
                        {
                            Id = new Guid("5773a9ef-1483-4992-a039-6a63fd77fa56"),
                            Content = "Research on this has ended. Here are the main reasons:",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1104),
                            IsDeleted = false,
                            PhotoPathForTrending = "img/news-100x100-5.jpg",
                            Title = "Why are women usually afraid of guns?"
                        },
                        new
                        {
                            Id = new Guid("768c9eac-ae30-449e-b4f3-5d3aa8fedb0f"),
                            Content = "The Ministry of Education announced its decision:",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1106),
                            IsDeleted = false,
                            PhotoPathSingleBig = "img/news-700x435-1.jpg",
                            Title = "Important development for kindergartens"
                        },
                        new
                        {
                            Id = new Guid("8651b1d2-8586-4dd5-b94d-0eef515a08e4"),
                            Content = "Are you ready to take your bodybuilding journey to the next level? Achieving optimal results in bodybuilding requires more than just lifting weights aimlessly. It demands a strategic approach, incorporating effective training techniques tailored to your goals and body type. Here are some key strategies to help you maximize your workouts and achieve the gains you desire:\r\n\r\n1. *Progressive Overload:* One of the fundamental principles of bodybuilding is progressive overload. This involves gradually increasing the stress placed on your muscles over time to stimulate growth. Whether it's adding more weight to your lifts, increasing the number of reps, or shortening rest periods between sets, consistently challenging your muscles is essential for continual progress. 2. *Compound Movements:* Focus on compound exercises that target multiple muscle groups simultaneously, such as squats, deadlifts, bench presses, and pull-ups. These compound movements not only build strength and muscle mass more efficiently but also engage stabilizing muscles, enhancing overall muscle development and functional strength.",
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1112),
                            IsDeleted = false,
                            PhotoPathForCategories = "img/Jerry Ossi_992401984_o.jpg",
                            PhotoPathSingleBig = "img/Jerry Ossi_992401984_o.jpg",
                            Title = "Effective Training Techniques for Optimal Results"
                        });
                });

            modelBuilder.Entity("MYNEWS.Entities.NewsTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("NewsTags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a294e953-3459-47af-a516-5b434767985f"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1370),
                            IsDeleted = false,
                            TagName = "#Health"
                        },
                        new
                        {
                            Id = new Guid("ff9ea92d-f85a-494a-ab03-015b96edf559"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1376),
                            IsDeleted = false,
                            TagName = "#MedicalAdvancements"
                        },
                        new
                        {
                            Id = new Guid("c32886bf-50cb-4828-b41e-cdf360a5e608"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1379),
                            IsDeleted = false,
                            TagName = "#CancerResearch"
                        },
                        new
                        {
                            Id = new Guid("d210a6cb-d9cc-4977-b7fe-7d2c04d43334"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1382),
                            IsDeleted = false,
                            TagName = "#TreatmentOptions"
                        },
                        new
                        {
                            Id = new Guid("43173774-3de9-43a3-a868-fe4b6abaeb3e"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1384),
                            IsDeleted = false,
                            TagName = "#Efficiency"
                        },
                        new
                        {
                            Id = new Guid("15c7496e-177e-425b-9e02-5721b45b421c"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1391),
                            IsDeleted = false,
                            TagName = "#BusinessTips"
                        },
                        new
                        {
                            Id = new Guid("8f5aad48-a79e-476d-866a-1fa516a8116e"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1393),
                            IsDeleted = false,
                            TagName = "#Productivity"
                        },
                        new
                        {
                            Id = new Guid("b335e367-b773-4495-b9ea-0782a71df79b"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1395),
                            IsDeleted = false,
                            TagName = "#StrategicManagement"
                        },
                        new
                        {
                            Id = new Guid("f0d30eca-64e0-45f9-b46a-844ca8ec6fe1"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1398),
                            IsDeleted = false,
                            TagName = "#Technology"
                        },
                        new
                        {
                            Id = new Guid("71866dbd-e888-444b-a76e-9fa21b831254"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1402),
                            IsDeleted = false,
                            TagName = "#TechProducts"
                        },
                        new
                        {
                            Id = new Guid("0c5781e8-8403-4c3e-9847-9790e2c66f51"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1405),
                            IsDeleted = false,
                            TagName = "#Innovation"
                        },
                        new
                        {
                            Id = new Guid("ad3cbe2a-5907-4bb7-b5d9-de105dd36f48"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1410),
                            IsDeleted = false,
                            TagName = "#TechTrends"
                        },
                        new
                        {
                            Id = new Guid("b10d6478-a05d-4d03-b929-86bc60b5295c"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1412),
                            IsDeleted = false,
                            TagName = "#GenderRoles"
                        },
                        new
                        {
                            Id = new Guid("257b61a4-bd60-4090-9eeb-aa8c7578fd55"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1417),
                            IsDeleted = false,
                            TagName = "#GunSafety"
                        },
                        new
                        {
                            Id = new Guid("82b6e281-f14a-42a2-b570-3f5cb91cc4a1"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1419),
                            IsDeleted = false,
                            TagName = "#Women"
                        },
                        new
                        {
                            Id = new Guid("b75389de-5aa3-4235-9472-fc23b6f425b5"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1422),
                            IsDeleted = false,
                            TagName = "#SocietalFear"
                        },
                        new
                        {
                            Id = new Guid("8265d213-23f8-4769-9bde-aa3409307f3e"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1424),
                            IsDeleted = false,
                            TagName = "#Education"
                        },
                        new
                        {
                            Id = new Guid("dadf6ec5-8be4-4eb8-ae6b-8f4bf0bb9ee1"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1429),
                            IsDeleted = false,
                            TagName = "#Kindergarten"
                        },
                        new
                        {
                            Id = new Guid("91d6b836-24cd-4767-bb82-f7f2b8257c4d"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1431),
                            IsDeleted = false,
                            TagName = "#ChildDevelopment"
                        },
                        new
                        {
                            Id = new Guid("db106fc8-1a7f-4e76-8c71-db4ac32c7a4c"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1433),
                            IsDeleted = false,
                            TagName = "#EarlyEducation"
                        });
                });

            modelBuilder.Entity("MYNEWS.Entities.Subcategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("SubcategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("95a51760-f1d3-435c-98bd-3aa3d3f146c5"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1303),
                            IsDeleted = false,
                            SubcategoryName = "Medical and Health News"
                        },
                        new
                        {
                            Id = new Guid("8c3b2855-f392-459f-ad31-2f59a2962a5a"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1308),
                            IsDeleted = false,
                            SubcategoryName = "Strategic Management and Planning"
                        },
                        new
                        {
                            Id = new Guid("a04fa07c-b7bc-4c50-ae06-dce4d0a3f83f"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1315),
                            IsDeleted = false,
                            SubcategoryName = "Information Technology and Information Systems"
                        },
                        new
                        {
                            Id = new Guid("9bc49baf-cd7c-42ce-bfb0-2af8832eeb42"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1317),
                            IsDeleted = false,
                            SubcategoryName = "Gender and Analysis of Gender Roles in Society"
                        },
                        new
                        {
                            Id = new Guid("0e7ff060-1ed3-4dd4-a6d8-f86ceb401521"),
                            CreatedAt = new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1322),
                            IsDeleted = false,
                            SubcategoryName = "Schools and Educational Institutions"
                        });
                });

            modelBuilder.Entity("NewsNewsTag", b =>
                {
                    b.Property<Guid>("NewsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NewsTagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("NewsId", "NewsTagsId");

                    b.HasIndex("NewsTagsId");

                    b.ToTable("NewsNewsTag");
                });

            modelBuilder.Entity("AuthorNews", b =>
                {
                    b.HasOne("MYNEWS.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MYNEWS.Entities.News", null)
                        .WithMany()
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MYNEWS.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MYNEWS.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MYNEWS.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MYNEWS.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MYNEWS.Entities.Comment", b =>
                {
                    b.HasOne("MYNEWS.Entities.AppUser", "AppUser")
                        .WithMany("Comments")
                        .HasForeignKey("AppUserId");

                    b.HasOne("MYNEWS.Entities.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId");

                    b.Navigation("AppUser");

                    b.Navigation("News");
                });

            modelBuilder.Entity("MYNEWS.Entities.News", b =>
                {
                    b.HasOne("MYNEWS.Entities.Category", "Category")
                        .WithMany("News")
                        .HasForeignKey("CategoryId");

                    b.HasOne("MYNEWS.Entities.Subcategory", "Subcategory")
                        .WithMany("News")
                        .HasForeignKey("SubcategoryId");

                    b.Navigation("Category");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("MYNEWS.Entities.Subcategory", b =>
                {
                    b.HasOne("MYNEWS.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NewsNewsTag", b =>
                {
                    b.HasOne("MYNEWS.Entities.News", null)
                        .WithMany()
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MYNEWS.Entities.NewsTag", null)
                        .WithMany()
                        .HasForeignKey("NewsTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MYNEWS.Entities.AppUser", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("MYNEWS.Entities.Category", b =>
                {
                    b.Navigation("News");

                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("MYNEWS.Entities.News", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("MYNEWS.Entities.Subcategory", b =>
                {
                    b.Navigation("News");
                });
#pragma warning restore 612, 618
        }
    }
}
