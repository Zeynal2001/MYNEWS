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
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilePhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    LongPhotoPathForCategories = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    PhotoPathForFeatured = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathForCategories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathForUserComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2533dbf7-2f8c-4a34-a384-683ea4a09888", "a02a92e0-eb07-4476-81d0-30c1600ae50e", "Admin", "ADMIN" },
                    { "290474d2-f5fe-47f4-9a33-6940d6475cef", "5ca0ee0a-ad68-4143-b5e3-e09076bc044d", "Moderator", "MODERATOR" },
                    { "3216ef84-b790-45f1-b9a3-649e8f999203", "34ccee16-d3dc-45b0-bc42-7209b78e45d1", "Client", "CLIENT" },
                    { "b1a03e9e-a949-44f7-be1e-786235131781", "2d7822ee-a159-45b8-934f-0e271ab60f6f", "None", "NONE" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "IsDeleted", "LongPhotoPathForCategories", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("15fbad38-fe44-4fdd-b037-47062e4ac3dc"), "Society and Culture", new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(73), false, null, null },
                    { new Guid("38c7f3fd-5ac2-47b2-84eb-a5f2a345f6d2"), "Education", new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(76), false, null, null },
                    { new Guid("732f0bab-a28f-4270-bfab-03e3604f55c4"), "Health", new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(55), false, null, null },
                    { new Guid("8c6bb045-2ebf-48f8-ba98-d8af41f14ae1"), "Sport", new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(79), false, "img/cat-500x80-4.jpg", null },
                    { new Guid("a2750746-dacf-4c4d-9dd8-b41028bbc8a8"), "Entertainment", new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(81), false, "img/cat-500x80-3.jpg", null },
                    { new Guid("bbcdfb5c-0f5e-4faa-bef6-3da80d5b9e7d"), "Technology", new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(70), false, "img/cat-500x80-2.jpg", null },
                    { new Guid("fe74338f-17c3-4a10-a413-a57284c48bb2"), "Business", new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(63), false, "img/cat-500x80-1.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "IsDeleted", "PhotoPathForCategories", "PhotoPathForFeatured", "PhotoPathForTrending", "PhotoPathForUserComment", "PhotoPathSingleBig", "SubcategoryId", "Title", "UpdatedAt", "ViewsCount" },
                values: new object[,]
                {
                    { new Guid("5e3fc979-2e3d-42aa-b53e-0fa244a324eb"), null, "Research on this has ended. Here are the main reasons:", new DateTime(2024, 4, 21, 12, 34, 21, 475, DateTimeKind.Utc).AddTicks(9975), false, null, null, "img/news-100x100-5.jpg", null, null, null, "Why are women usually afraid of guns?", null, 0 },
                    { new Guid("61182b8f-7c7a-4250-8e12-c7dbd1a8ba26"), null, "Now it's possible. How? Let's dive in:", new DateTime(2024, 4, 21, 12, 34, 21, 475, DateTimeKind.Utc).AddTicks(9962), false, null, null, "img/news-100x100-1.jpg", null, null, null, "Medicine can now put a stop to cancer", null, 0 },
                    { new Guid("a9c94341-6208-41f3-b405-ec5b9f6fd2bc"), null, "Are you ready to take your bodybuilding journey to the next level? Achieving optimal results in bodybuilding requires more than just lifting weights aimlessly. It demands a strategic approach, incorporating effective training techniques tailored to your goals and body type. Here are some key strategies to help you maximize your workouts and achieve the gains you desire:\r\n\r\n1. *Progressive Overload:* One of the fundamental principles of bodybuilding is progressive overload. This involves gradually increasing the stress placed on your muscles over time to stimulate growth. Whether it's adding more weight to your lifts, increasing the number of reps, or shortening rest periods between sets, consistently challenging your muscles is essential for continual progress. 2. *Compound Movements:* Focus on compound exercises that target multiple muscle groups simultaneously, such as squats, deadlifts, bench presses, and pull-ups. These compound movements not only build strength and muscle mass more efficiently but also engage stabilizing muscles, enhancing overall muscle development and functional strength.", new DateTime(2024, 4, 21, 12, 34, 21, 475, DateTimeKind.Utc).AddTicks(9983), false, "img/Jerry Ossi_992401984_o.jpg", null, null, null, "img/Jerry Ossi_992401984_o.jpg", null, "Effective Training Techniques for Optimal Results", null, 0 },
                    { new Guid("b32cc1fa-b341-4d16-81e7-3313fb947a6a"), null, "This is easy", new DateTime(2024, 4, 21, 12, 34, 21, 475, DateTimeKind.Utc).AddTicks(9970), false, null, null, "img/news-100x100-2.jpg", null, null, null, "How can you increase your efficiency in your business?", null, 0 },
                    { new Guid("c30200d4-9042-4243-ab12-05d7add27c54"), null, "The Ministry of Education announced its decision:", new DateTime(2024, 4, 21, 12, 34, 21, 475, DateTimeKind.Utc).AddTicks(9977), false, null, null, null, null, "img/news-700x435-1.jpg", null, "Important development for kindergartens", null, 0 },
                    { new Guid("d927a365-330d-4dc4-be2b-ea480dddb01a"), null, "Here in this article, we have listed them for you. Continue:", new DateTime(2024, 4, 21, 12, 34, 21, 475, DateTimeKind.Utc).AddTicks(9973), false, null, null, "img/news-100x100-3.jpg", null, null, null, "The best technological products released this year?", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "NewsTags",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TagName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c4ae89d-0ecc-4824-ad3b-b60bfbc778ce"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(222), false, "#Technology", null },
                    { new Guid("137d23f4-add3-4dd0-8038-77c0a512641b"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(231), false, "#GenderRoles", null },
                    { new Guid("1ef68e0f-4b77-438d-8ad5-0d17d437e36e"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(239), false, "#Women", null },
                    { new Guid("2068b0fa-7c97-4340-8bd9-68e68e9f3e87"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(207), false, "#CancerResearch", null },
                    { new Guid("2b640314-b7fb-4b67-9dbb-7d4d8f29ad6f"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(249), false, "#ChildDevelopment", null },
                    { new Guid("448c3feb-e859-4283-9317-0e3b7da3d1a8"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(218), false, "#Productivity", null },
                    { new Guid("47d63de6-6174-4baa-888a-f87ad72c3a41"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(228), false, "#Innovation", null },
                    { new Guid("61718f5b-3bd3-4237-88b4-65ccd3422415"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(226), false, "#TechProducts", null },
                    { new Guid("6f03a45c-da63-42ea-b7f4-b23cee83db71"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(211), false, "#Efficiency", null },
                    { new Guid("80599ba0-743f-4e72-9c5a-219d7f2d5b6a"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(241), false, "#SocietalFear", null },
                    { new Guid("88cba31a-2e7d-44ce-8213-356952d07663"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(246), false, "#Kindergarten", null },
                    { new Guid("9be9026f-ef57-4540-b790-50296ea51e85"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(205), false, "#MedicalAdvancements", null },
                    { new Guid("9e03b9ad-a8a0-4b0b-b9b8-4c5cc55ef09b"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(233), false, "#GunSafety", null },
                    { new Guid("b21e1c41-d725-4ba1-927a-a593b85d3f05"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(201), false, "#Health", null },
                    { new Guid("d12a32c7-33b8-4fba-8d04-a959480291bb"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(230), false, "#TechTrends", null },
                    { new Guid("d1d151d9-ece5-4883-8cf9-b0104e52d71b"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(251), false, "#EarlyEducation", null },
                    { new Guid("d521156a-98f6-4151-9bfc-d2c7c548cbec"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(209), false, "#TreatmentOptions", null },
                    { new Guid("d6cbf412-c46f-42b0-b597-68cf5f2b5998"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(242), false, "#Education", null },
                    { new Guid("f4aa00b4-a14d-45c4-a6b3-c016ebbf4d7a"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(220), false, "#StrategicManagement", null },
                    { new Guid("f7e0332a-16f5-4afc-8017-ed8b09776b9d"), new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(213), false, "#BusinessTips", null }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "SubcategoryName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("60e27b84-b646-4d13-9722-a8a08f852c86"), null, new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(144), false, "Schools and Educational Institutions", null },
                    { new Guid("66b671ee-e1df-4727-8ab9-e72f05b5e032"), null, new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(132), false, "Information Technology and Information Systems", null },
                    { new Guid("760055dc-9e98-4295-a4ff-569faef0b51d"), null, new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(125), false, "Medical and Health News", null },
                    { new Guid("7d1408c1-13ed-4f76-80e4-7674433a7307"), null, new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(131), false, "Strategic Management and Planning", null },
                    { new Guid("c07dd0f5-6890-46a4-86f0-c981ced8331b"), null, new DateTime(2024, 4, 21, 12, 34, 21, 476, DateTimeKind.Utc).AddTicks(141), false, "Gender and Analysis of Gender Roles in Society", null }
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
