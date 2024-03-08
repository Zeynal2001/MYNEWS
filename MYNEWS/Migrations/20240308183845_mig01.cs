using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYNEWS.Migrations
{
    public partial class mig01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ProfilePhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPathForTrending = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathSingleBig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongPhotoPathForCategories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathForFeatured = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathForCategories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathForUserComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewsCount = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_News_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorNews",
                columns: table => new
                {
                    AuthorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorNews", x => new { x.AuthorsId, x.NewsId });
                    table.ForeignKey(
                        name: "FK_AuthorNews_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorNews_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vote = table.Column<int>(type: "int", nullable: true),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NewsNewsTag",
                columns: table => new
                {
                    NewsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewsTagsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsNewsTag", x => new { x.NewsId, x.NewsTagsId });
                    table.ForeignKey(
                        name: "FK_NewsNewsTag_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsNewsTag_NewsTags_NewsTagsId",
                        column: x => x.NewsTagsId,
                        principalTable: "NewsTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4807ed0b-8863-42d5-a381-81c5ee0b6494"), "Health", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6335), false, null },
                    { new Guid("9f25fa00-e334-4d42-8bd1-5ec74e1db120"), "Education", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6343), false, null },
                    { new Guid("a5feb6ec-ef90-4fcf-adaa-6291db80e6bb"), "Society and Culture", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6341), false, null },
                    { new Guid("c0b351ce-23c9-4ea2-a642-071f5a5fb720"), "Technology", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6340), false, null },
                    { new Guid("c88c7808-9f2e-4521-be75-0b7000dd5050"), "Business", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6338), false, null }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "IsDeleted", "LongPhotoPathForCategories", "PhotoPathForCategories", "PhotoPathForFeatured", "PhotoPathForTrending", "PhotoPathForUserComment", "PhotoPathSingleBig", "SubcategoryId", "Title", "UpdatedAt", "ViewsCount" },
                values: new object[,]
                {
                    { new Guid("15cb084c-b8e0-4e7d-9308-5fca3ab68a01"), null, "Now it's possible. How? Let's dive in:", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6255), false, null, null, null, "img/news-100x100-1.jpg", null, null, null, "Medicine can now put a stop to cancer", null, null },
                    { new Guid("4ac322d8-7bce-4c55-8a12-7e120663198a"), null, "This is easy", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6260), false, null, null, null, "img/news-100x100-2.jpg", null, null, null, "How can you increase your efficiency in your business?", null, null },
                    { new Guid("958f816f-c182-47e2-b46e-5dde9d812e7d"), null, "Here in this article, we have listed them for you. Continue:", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6262), false, null, null, null, "img/news-100x100-3.jpg", null, null, null, "The best technological products released this year?", null, null },
                    { new Guid("bae39aa4-72c3-41d3-84a2-03856e3086ec"), null, "Research on this has ended. Here are the main reasons:", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6264), false, null, null, null, "img/news-100x100-5.jpg", null, null, null, "Why are women usually afraid of guns?", null, null },
                    { new Guid("de45998a-ca05-49c1-803f-788329259fdf"), null, "The Ministry of Education announced its decision:", new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6266), false, null, null, null, null, null, "img/news-700x435-1.jpg", null, "Important development for kindergartens", null, null }
                });

            migrationBuilder.InsertData(
                table: "NewsTags",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TagName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11ecaa36-e82e-4a6e-9da0-a2477822fa2c"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6432), false, "#CancerResearch", null },
                    { new Guid("343d0497-5d7d-43a3-8973-97649a1cd0ee"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6465), false, "#GunSafety", null },
                    { new Guid("3ae82180-0eff-4f08-8446-7ef96f4cb107"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6443), false, "#Productivity", null },
                    { new Guid("3e7b7949-6af9-4a15-997e-74f7482d42ca"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6463), false, "#GenderRoles", null },
                    { new Guid("4b3fbeb9-827a-4978-996b-e9f36772c9bf"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6434), false, "#TreatmentOptions", null },
                    { new Guid("5af96887-2cf4-49f2-a6ad-eea15500e4ba"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6470), false, "#Women", null },
                    { new Guid("6285405f-14fd-4130-831c-b3222c8f9d02"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6458), false, "#TechProducts", null },
                    { new Guid("6b3edd30-4444-4ee0-9c1f-dc798e3a512c"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6430), false, "#MedicalAdvancements", null },
                    { new Guid("7c07d96c-3dae-4c02-a930-6f504709ce24"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6462), false, "#TechTrends", null },
                    { new Guid("7e8b2676-680b-45ba-ad3b-21ea0ac18918"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6455), false, "#Technology", null },
                    { new Guid("886ddfec-c611-41d1-9f28-51455f059bc7"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6472), false, "#SocietalFear", null },
                    { new Guid("9cf1fd52-7d8b-4ad2-ae1f-15df30bad816"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6454), false, "#StrategicManagement", null },
                    { new Guid("a8b92c25-d055-43e7-be20-c4e936cf8b93"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6479), false, "#EarlyEducation", null },
                    { new Guid("acbe374a-3387-4553-a3bc-b4615323443d"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6435), false, "#Efficiency", null },
                    { new Guid("b3cdd45d-66d1-40c0-990f-64ec92f36899"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6460), false, "#Innovation", null },
                    { new Guid("bf6ac7b0-9bf9-4d4f-924d-d263d95808de"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6425), false, "#Health", null },
                    { new Guid("bff43dc9-e3d7-47ad-8499-0d2b0acde8a5"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6438), false, "#BusinessTips", null },
                    { new Guid("d746b569-f317-4b77-8256-34d2c7baa1a0"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6478), false, "#ChildDevelopment", null },
                    { new Guid("d7b41864-f553-4d3e-817f-6021949b75bf"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6473), false, "#Education", null },
                    { new Guid("fd3860b5-0974-4799-b356-baa7089d125c"), new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6476), false, "#Kindergarten", null }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "SubcategoryName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0411fb60-5c6b-437d-9f39-7b14047a1a3a"), null, new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6377), false, "Medical and Health News", null },
                    { new Guid("070ffe26-d467-49d6-b864-939a857eb9f3"), null, new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6388), false, "Gender and Analysis of Gender Roles in Society", null },
                    { new Guid("21801b3a-7486-44d5-9df2-ab67b2137b6f"), null, new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6383), false, "Information Technology and Information Systems", null },
                    { new Guid("803775d6-b369-4f8b-a7e5-b78577925f17"), null, new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6390), false, "Schools and Educational Institutions", null },
                    { new Guid("cfaefa09-b6c2-48e5-805c-b3c9d32261c5"), null, new DateTime(2024, 3, 8, 18, 38, 45, 367, DateTimeKind.Utc).AddTicks(6381), false, "Strategic Management and Planning", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorNews_NewsId",
                table: "AuthorNews",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NewsId",
                table: "Comments",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_News_SubcategoryId",
                table: "News",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_News_Title",
                table: "News",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsNewsTag_NewsTagsId",
                table: "NewsNewsTag",
                column: "NewsTagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuthorNews");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "NewsNewsTag");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "NewsTags");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
