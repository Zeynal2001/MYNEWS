using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYNEWS.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4807ed0b-8863-42d5-a381-81c5ee0b6494"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f25fa00-e334-4d42-8bd1-5ec74e1db120"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5feb6ec-ef90-4fcf-adaa-6291db80e6bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0b351ce-23c9-4ea2-a642-071f5a5fb720"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c88c7808-9f2e-4521-be75-0b7000dd5050"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("15cb084c-b8e0-4e7d-9308-5fca3ab68a01"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4ac322d8-7bce-4c55-8a12-7e120663198a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("958f816f-c182-47e2-b46e-5dde9d812e7d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("bae39aa4-72c3-41d3-84a2-03856e3086ec"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("de45998a-ca05-49c1-803f-788329259fdf"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("11ecaa36-e82e-4a6e-9da0-a2477822fa2c"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("343d0497-5d7d-43a3-8973-97649a1cd0ee"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("3ae82180-0eff-4f08-8446-7ef96f4cb107"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("3e7b7949-6af9-4a15-997e-74f7482d42ca"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("4b3fbeb9-827a-4978-996b-e9f36772c9bf"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("5af96887-2cf4-49f2-a6ad-eea15500e4ba"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("6285405f-14fd-4130-831c-b3222c8f9d02"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("6b3edd30-4444-4ee0-9c1f-dc798e3a512c"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("7c07d96c-3dae-4c02-a930-6f504709ce24"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("7e8b2676-680b-45ba-ad3b-21ea0ac18918"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("886ddfec-c611-41d1-9f28-51455f059bc7"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("9cf1fd52-7d8b-4ad2-ae1f-15df30bad816"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("a8b92c25-d055-43e7-be20-c4e936cf8b93"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("acbe374a-3387-4553-a3bc-b4615323443d"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("b3cdd45d-66d1-40c0-990f-64ec92f36899"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("bf6ac7b0-9bf9-4d4f-924d-d263d95808de"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("bff43dc9-e3d7-47ad-8499-0d2b0acde8a5"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("d746b569-f317-4b77-8256-34d2c7baa1a0"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("d7b41864-f553-4d3e-817f-6021949b75bf"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("fd3860b5-0974-4799-b356-baa7089d125c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("0411fb60-5c6b-437d-9f39-7b14047a1a3a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("070ffe26-d467-49d6-b864-939a857eb9f3"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("21801b3a-7486-44d5-9df2-ab67b2137b6f"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("803775d6-b369-4f8b-a7e5-b78577925f17"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("cfaefa09-b6c2-48e5-805c-b3c9d32261c5"));

            migrationBuilder.AddColumn<string>(
                name: "LongPhotoPathForCategories",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "IsDeleted", "LongPhotoPathForCategories", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0aa3390e-0efa-4b9c-b5f4-cf0a2ab22de7"), "Sport", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1240), false, "img/cat-500x80-4.jpg", null },
                    { new Guid("16dff4d7-d391-4283-b499-83de67367d04"), "Society and Culture", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1235), false, null, null },
                    { new Guid("4cb1560f-55dd-4448-a402-b1629c04126b"), "Technology", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1233), false, "img/cat-500x80-2.jpg", null },
                    { new Guid("662a8f20-a711-40cf-b90f-19c872fb6d78"), "Business", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1230), false, "img/cat-500x80-1.jpg", null },
                    { new Guid("9d503f11-b843-4aea-84ec-f35f0471e457"), "Education", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1237), false, null, null },
                    { new Guid("ae6a7abc-ba9d-496c-8de6-19e6e26c214a"), "Entertainment", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1243), false, "img/cat-500x80-3.jpg", null },
                    { new Guid("d36a91fc-a7de-4aa7-8933-774c4ccc9ba1"), "Health", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1202), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "IsDeleted", "LongPhotoPathForCategories", "PhotoPathForCategories", "PhotoPathForFeatured", "PhotoPathForTrending", "PhotoPathForUserComment", "PhotoPathSingleBig", "SubcategoryId", "Title", "UpdatedAt", "ViewsCount" },
                values: new object[,]
                {
                    { new Guid("329d3571-8f1b-4e06-840b-b4fa894817e2"), null, "Now it's possible. How? Let's dive in:", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(978), false, null, null, null, "img/news-100x100-1.jpg", null, null, null, "Medicine can now put a stop to cancer", null, null },
                    { new Guid("5773a9ef-1483-4992-a039-6a63fd77fa56"), null, "Research on this has ended. Here are the main reasons:", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1104), false, null, null, null, "img/news-100x100-5.jpg", null, null, null, "Why are women usually afraid of guns?", null, null },
                    { new Guid("768c9eac-ae30-449e-b4f3-5d3aa8fedb0f"), null, "The Ministry of Education announced its decision:", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1106), false, null, null, null, null, null, "img/news-700x435-1.jpg", null, "Important development for kindergartens", null, null },
                    { new Guid("77b8afa3-0763-4361-ba4f-0306ec4d4873"), null, "This is easy", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1098), false, null, null, null, "img/news-100x100-2.jpg", null, null, null, "How can you increase your efficiency in your business?", null, null },
                    { new Guid("8651b1d2-8586-4dd5-b94d-0eef515a08e4"), null, "Are you ready to take your bodybuilding journey to the next level? Achieving optimal results in bodybuilding requires more than just lifting weights aimlessly. It demands a strategic approach, incorporating effective training techniques tailored to your goals and body type. Here are some key strategies to help you maximize your workouts and achieve the gains you desire:\r\n\r\n1. *Progressive Overload:* One of the fundamental principles of bodybuilding is progressive overload. This involves gradually increasing the stress placed on your muscles over time to stimulate growth. Whether it's adding more weight to your lifts, increasing the number of reps, or shortening rest periods between sets, consistently challenging your muscles is essential for continual progress. 2. *Compound Movements:* Focus on compound exercises that target multiple muscle groups simultaneously, such as squats, deadlifts, bench presses, and pull-ups. These compound movements not only build strength and muscle mass more efficiently but also engage stabilizing muscles, enhancing overall muscle development and functional strength.", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1112), false, null, "img/Jerry Ossi_992401984_o.jpg", null, null, null, "img/Jerry Ossi_992401984_o.jpg", null, "Effective Training Techniques for Optimal Results", null, null },
                    { new Guid("cb9ce477-e66d-452a-a669-61188d2d2c36"), null, "Here in this article, we have listed them for you. Continue:", new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1101), false, null, null, null, "img/news-100x100-3.jpg", null, null, null, "The best technological products released this year?", null, null }
                });

            migrationBuilder.InsertData(
                table: "NewsTags",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TagName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c5781e8-8403-4c3e-9847-9790e2c66f51"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1405), false, "#Innovation", null },
                    { new Guid("15c7496e-177e-425b-9e02-5721b45b421c"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1391), false, "#BusinessTips", null },
                    { new Guid("257b61a4-bd60-4090-9eeb-aa8c7578fd55"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1417), false, "#GunSafety", null },
                    { new Guid("43173774-3de9-43a3-a868-fe4b6abaeb3e"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1384), false, "#Efficiency", null },
                    { new Guid("71866dbd-e888-444b-a76e-9fa21b831254"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1402), false, "#TechProducts", null },
                    { new Guid("8265d213-23f8-4769-9bde-aa3409307f3e"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1424), false, "#Education", null },
                    { new Guid("82b6e281-f14a-42a2-b570-3f5cb91cc4a1"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1419), false, "#Women", null },
                    { new Guid("8f5aad48-a79e-476d-866a-1fa516a8116e"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1393), false, "#Productivity", null },
                    { new Guid("91d6b836-24cd-4767-bb82-f7f2b8257c4d"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1431), false, "#ChildDevelopment", null },
                    { new Guid("a294e953-3459-47af-a516-5b434767985f"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1370), false, "#Health", null },
                    { new Guid("ad3cbe2a-5907-4bb7-b5d9-de105dd36f48"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1410), false, "#TechTrends", null },
                    { new Guid("b10d6478-a05d-4d03-b929-86bc60b5295c"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1412), false, "#GenderRoles", null },
                    { new Guid("b335e367-b773-4495-b9ea-0782a71df79b"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1395), false, "#StrategicManagement", null },
                    { new Guid("b75389de-5aa3-4235-9472-fc23b6f425b5"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1422), false, "#SocietalFear", null },
                    { new Guid("c32886bf-50cb-4828-b41e-cdf360a5e608"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1379), false, "#CancerResearch", null },
                    { new Guid("d210a6cb-d9cc-4977-b7fe-7d2c04d43334"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1382), false, "#TreatmentOptions", null },
                    { new Guid("dadf6ec5-8be4-4eb8-ae6b-8f4bf0bb9ee1"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1429), false, "#Kindergarten", null },
                    { new Guid("db106fc8-1a7f-4e76-8c71-db4ac32c7a4c"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1433), false, "#EarlyEducation", null },
                    { new Guid("f0d30eca-64e0-45f9-b46a-844ca8ec6fe1"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1398), false, "#Technology", null },
                    { new Guid("ff9ea92d-f85a-494a-ab03-015b96edf559"), new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1376), false, "#MedicalAdvancements", null }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "SubcategoryName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e7ff060-1ed3-4dd4-a6d8-f86ceb401521"), null, new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1322), false, "Schools and Educational Institutions", null },
                    { new Guid("8c3b2855-f392-459f-ad31-2f59a2962a5a"), null, new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1308), false, "Strategic Management and Planning", null },
                    { new Guid("95a51760-f1d3-435c-98bd-3aa3d3f146c5"), null, new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1303), false, "Medical and Health News", null },
                    { new Guid("9bc49baf-cd7c-42ce-bfb0-2af8832eeb42"), null, new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1317), false, "Gender and Analysis of Gender Roles in Society", null },
                    { new Guid("a04fa07c-b7bc-4c50-ae06-dce4d0a3f83f"), null, new DateTime(2024, 3, 15, 10, 19, 53, 42, DateTimeKind.Utc).AddTicks(1315), false, "Information Technology and Information Systems", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0aa3390e-0efa-4b9c-b5f4-cf0a2ab22de7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16dff4d7-d391-4283-b499-83de67367d04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4cb1560f-55dd-4448-a402-b1629c04126b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("662a8f20-a711-40cf-b90f-19c872fb6d78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d503f11-b843-4aea-84ec-f35f0471e457"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae6a7abc-ba9d-496c-8de6-19e6e26c214a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d36a91fc-a7de-4aa7-8933-774c4ccc9ba1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("329d3571-8f1b-4e06-840b-b4fa894817e2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5773a9ef-1483-4992-a039-6a63fd77fa56"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("768c9eac-ae30-449e-b4f3-5d3aa8fedb0f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("77b8afa3-0763-4361-ba4f-0306ec4d4873"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("8651b1d2-8586-4dd5-b94d-0eef515a08e4"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("cb9ce477-e66d-452a-a669-61188d2d2c36"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("0c5781e8-8403-4c3e-9847-9790e2c66f51"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("15c7496e-177e-425b-9e02-5721b45b421c"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("257b61a4-bd60-4090-9eeb-aa8c7578fd55"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("43173774-3de9-43a3-a868-fe4b6abaeb3e"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("71866dbd-e888-444b-a76e-9fa21b831254"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("8265d213-23f8-4769-9bde-aa3409307f3e"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("82b6e281-f14a-42a2-b570-3f5cb91cc4a1"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("8f5aad48-a79e-476d-866a-1fa516a8116e"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("91d6b836-24cd-4767-bb82-f7f2b8257c4d"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("a294e953-3459-47af-a516-5b434767985f"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("ad3cbe2a-5907-4bb7-b5d9-de105dd36f48"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("b10d6478-a05d-4d03-b929-86bc60b5295c"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("b335e367-b773-4495-b9ea-0782a71df79b"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("b75389de-5aa3-4235-9472-fc23b6f425b5"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("c32886bf-50cb-4828-b41e-cdf360a5e608"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("d210a6cb-d9cc-4977-b7fe-7d2c04d43334"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("dadf6ec5-8be4-4eb8-ae6b-8f4bf0bb9ee1"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("db106fc8-1a7f-4e76-8c71-db4ac32c7a4c"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("f0d30eca-64e0-45f9-b46a-844ca8ec6fe1"));

            migrationBuilder.DeleteData(
                table: "NewsTags",
                keyColumn: "Id",
                keyValue: new Guid("ff9ea92d-f85a-494a-ab03-015b96edf559"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("0e7ff060-1ed3-4dd4-a6d8-f86ceb401521"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("8c3b2855-f392-459f-ad31-2f59a2962a5a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("95a51760-f1d3-435c-98bd-3aa3d3f146c5"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9bc49baf-cd7c-42ce-bfb0-2af8832eeb42"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a04fa07c-b7bc-4c50-ae06-dce4d0a3f83f"));

            migrationBuilder.DropColumn(
                name: "LongPhotoPathForCategories",
                table: "Categories");

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
        }
    }
}
