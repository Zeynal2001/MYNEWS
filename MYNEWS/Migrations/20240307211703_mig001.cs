using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYNEWS.Migrations
{
    public partial class mig001 : Migration
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
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
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
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vote = table.Column<int>(type: "int", nullable: true),
                    NewsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11bbfd13-c8cc-4d08-8c3d-165ccceb7144"), "Business", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1134), false, null },
                    { new Guid("c5cc9f08-c983-430a-b40a-d398c3938cf4"), "Technology", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1136), false, null },
                    { new Guid("ce3a5409-2f54-45d9-a77b-b441267cc2fe"), "Education", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1139), false, null },
                    { new Guid("e0200635-f56d-4e57-9bd5-796da69b5ff0"), "Society and Culture", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1138), false, null },
                    { new Guid("ec6afdd8-908e-40a0-ba28-625312a5ad77"), "Health", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1109), false, null }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt", "IsDeleted", "LongPhotoPathForCategories", "PhotoPathForCategories", "PhotoPathForFeatured", "PhotoPathForTrending", "PhotoPathForUserComment", "PhotoPathSingleBig", "Title", "UpdatedAt", "ViewsCount" },
                values: new object[,]
                {
                    { new Guid("29de72ab-8c84-4013-8e1a-e8055901d2bc"), null, "Now it's possible. How? Let's dive in:", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1028), false, null, null, null, "img/news-100x100-1.jpg", null, null, "Medicine can now put a stop to cancer", null, null },
                    { new Guid("2c08f0df-bb92-47ed-b1ed-ff2e9d822687"), null, "Research on this has ended. Here are the main reasons:", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1036), false, null, null, null, "img/news-100x100-5.jpg", null, null, "Why are women usually afraid of guns?", null, null },
                    { new Guid("64c71c6c-b2a0-44cc-933e-2d2e2f67d2c8"), null, "Here in this article, we have listed them for you. Continue:", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1035), false, null, null, null, "img/news-100x100-3.jpg", null, null, "The best technological products released this year?", null, null },
                    { new Guid("de833050-c7d3-4aa7-ad03-61257d3ccd58"), null, "The Ministry of Education announced its decision:", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1038), false, null, null, null, null, null, "img/news-700x435-1.jpg", "Important development for kindergartens", null, null },
                    { new Guid("f10c6527-4837-4c13-931f-5986b8ce4843"), null, "This is easy", new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1033), false, null, null, null, "img/news-100x100-2.jpg", null, null, "How can you increase your efficiency in your business?", null, null }
                });

            migrationBuilder.InsertData(
                table: "NewsTags",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TagName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f356242-972c-431c-876b-65c50052cf98"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1237), false, "#CancerResearch", null },
                    { new Guid("1834dbaa-5b5d-4d49-bc4c-fe5145cb62b0"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1282), false, "#Productivity", null },
                    { new Guid("1a7a5f77-22fe-4d14-83ae-a1390268a236"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1305), false, "#Women", null },
                    { new Guid("20ec64c3-714d-402d-9597-4a972c3a9b6e"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1289), false, "#StrategicManagement", null },
                    { new Guid("25b282d3-8498-45c6-b8a8-cdaa0dc9dc48"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1301), false, "#GenderRoles", null },
                    { new Guid("2d91ae14-617d-4014-901d-eaecb54e0199"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1312), false, "#Education", null },
                    { new Guid("3d8e3e4b-b899-4199-a8e3-15128d1c0a1b"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1297), false, "#Innovation", null },
                    { new Guid("479bc7ce-2307-4a9c-93ab-662f5e5174b1"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1316), false, "#Kindergarten", null },
                    { new Guid("665d3ce2-51fa-4d96-94c8-fe296cda7eaf"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1231), false, "#Health", null },
                    { new Guid("73cbbd6c-991f-4d13-b7a3-95d8331f6b2e"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1238), false, "#TreatmentOptions", null },
                    { new Guid("a036fcb2-fa0f-4c08-8087-ace2ec33846a"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1240), false, "#Efficiency", null },
                    { new Guid("a7da5142-7aa7-4132-877a-d67e77715aa5"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1299), false, "#TechTrends", null },
                    { new Guid("b1f07ac9-f0c6-4718-b365-6914fb1dd1dd"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1310), false, "#SocietalFear", null },
                    { new Guid("bb58eed4-ecce-4d43-aaf9-4137531335a8"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1303), false, "#GunSafety", null },
                    { new Guid("c3d88511-afd2-4199-9257-3677aa81d792"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1295), false, "#TechProducts", null },
                    { new Guid("c4219a2a-53b4-4910-a583-44f83c5469cd"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1318), false, "#ChildDevelopment", null },
                    { new Guid("c7218e0c-22da-4d1b-8fbe-c4c93e5e4fda"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1291), false, "#Technology", null },
                    { new Guid("d0ce4dd4-c06e-4463-afbe-29f51c753ce9"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1280), false, "#BusinessTips", null },
                    { new Guid("d777034b-e3e6-45d2-b756-d1cd707f772a"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1235), false, "#MedicalAdvancements", null },
                    { new Guid("de45e969-2b70-41db-9983-5d28c020b758"), new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1320), false, "#EarlyEducation", null }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "SubcategoryName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2b2c06cb-8995-49a9-b269-b83ccadc3ee8"), null, new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1181), false, "Medical and Health News", null },
                    { new Guid("32f54c7f-e4d3-4172-bc8d-610928212dd4"), null, new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1185), false, "Strategic Management and Planning", null },
                    { new Guid("52c80779-bf95-4936-a572-fe68c811abff"), null, new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1186), false, "Information Technology and Information Systems", null },
                    { new Guid("775ade03-0faf-4f77-844e-e38bd4844441"), null, new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1188), false, "Gender and Analysis of Gender Roles in Society", null },
                    { new Guid("f1aa3836-6e05-4f5e-ba6c-1ad25051f62d"), null, new DateTime(2024, 3, 7, 21, 17, 3, 433, DateTimeKind.Utc).AddTicks(1194), false, "Schools and Educational Institutions", null }
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
                name: "IX_Comments_NewsId",
                table: "Comments",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_Title",
                table: "News",
                column: "Title",
                unique: true);

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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "NewsTags");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
