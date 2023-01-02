using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class AddedCreatedOnAttributeOnBookAndDaysOfWaiting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4f631c86-0aa7-4fe3-8fb3-34efd9d1dfa3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8dd10184-a706-4978-9635-9a3994650c6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c87927c8-3905-4045-8f11-87113235be53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e04b1c0c-4989-424d-8cbb-8e0197c84661"));

            migrationBuilder.DeleteData(
                table: "Config",
                keyColumn: "ConfigId",
                keyValue: new Guid("5dc06ca2-403a-4628-9207-0278a5b2d6b5"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("05976cbc-f50b-42d2-aaf6-848668a3d9d1"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("1e8b074f-ef1b-41b6-aa9c-d4c24ad780c2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("21ea9c42-b950-4a23-9a26-ce2a836ffc10"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("9362cdf6-6d96-43f9-8fe3-5f8e3cdb8797"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("0a9cb226-5d3e-4e0f-8093-c9fc55daa1ac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("483a45d9-3743-42d6-a1ee-6f37f05ab97d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6268d369-fef0-4d26-8ea8-9280c2a98c08"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("92227a5b-8bf2-464f-983f-36cbda238e9b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("cad8d076-023c-4b40-b61d-ce7ae3ee5eb9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("e8c4fab7-dd7d-4328-8b45-aff3d5d2222a"));

            migrationBuilder.AddColumn<int>(
                name: "DaysOfWaiting",
                table: "BorrowCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("a8695201-7668-486c-b43a-f88807daf1a1"), "Fantastyka" },
                    { new Guid("8646ef51-90bb-413d-b06c-fa7e89f35bda"), "Horror" },
                    { new Guid("e3620e81-f31c-4706-b68e-95a7c48956ee"), "Sci-Fi" },
                    { new Guid("c7583933-ea4a-43fd-966c-a499c525a8ac"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Config",
                columns: new[] { "ConfigId", "Key", "Value" },
                values: new object[] { new Guid("b88a9145-b41c-4b4a-8553-0674795fd3f1"), "maxBorrowDaysAllowed", "30" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("9ea809aa-fd93-4328-a557-8d929cd69810"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 16, 53, 30, 633, DateTimeKind.Local).AddTicks(2747), "Lorem ipsum dolor sit amet", null },
                    { new Guid("1505ea3e-bd1d-4381-aa9c-82cc3c347dfe"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 16, 53, 30, 635, DateTimeKind.Local).AddTicks(7608), "Lorem ipsum dolor sit amet", null },
                    { new Guid("24748a34-b3af-4603-b9a8-7bc4ad635a24"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 16, 53, 30, 635, DateTimeKind.Local).AddTicks(7654), "Lorem ipsum dolor sit amet", null },
                    { new Guid("95c2d554-07cd-413b-8199-e5ad00630f96"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 16, 53, 30, 635, DateTimeKind.Local).AddTicks(7685), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("3146654b-f357-4b88-98a5-4dd8a9bd3174"), "Broń" },
                    { new Guid("d12de02b-6f96-492e-87bd-2edf8c40fee8"), "Magia" },
                    { new Guid("6424c18b-9bab-48b5-94d3-df7b43514229"), "Krew" },
                    { new Guid("d157727c-137e-43a4-a424-13dfa54e147b"), "Psychologiczne" },
                    { new Guid("01fff746-7471-4f0c-88c9-9c5f39a49552"), "Historia polska" },
                    { new Guid("2235164c-b93a-4809-8b8b-3815a9b69bca"), "Historia zagraniczna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8646ef51-90bb-413d-b06c-fa7e89f35bda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8695201-7668-486c-b43a-f88807daf1a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c7583933-ea4a-43fd-966c-a499c525a8ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e3620e81-f31c-4706-b68e-95a7c48956ee"));

            migrationBuilder.DeleteData(
                table: "Config",
                keyColumn: "ConfigId",
                keyValue: new Guid("b88a9145-b41c-4b4a-8553-0674795fd3f1"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("1505ea3e-bd1d-4381-aa9c-82cc3c347dfe"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("24748a34-b3af-4603-b9a8-7bc4ad635a24"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("95c2d554-07cd-413b-8199-e5ad00630f96"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("9ea809aa-fd93-4328-a557-8d929cd69810"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("01fff746-7471-4f0c-88c9-9c5f39a49552"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("2235164c-b93a-4809-8b8b-3815a9b69bca"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("3146654b-f357-4b88-98a5-4dd8a9bd3174"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6424c18b-9bab-48b5-94d3-df7b43514229"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("d12de02b-6f96-492e-87bd-2edf8c40fee8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("d157727c-137e-43a4-a424-13dfa54e147b"));

            migrationBuilder.DropColumn(
                name: "DaysOfWaiting",
                table: "BorrowCartItems");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("4f631c86-0aa7-4fe3-8fb3-34efd9d1dfa3"), "Fantastyka" },
                    { new Guid("e04b1c0c-4989-424d-8cbb-8e0197c84661"), "Horror" },
                    { new Guid("c87927c8-3905-4045-8f11-87113235be53"), "Sci-Fi" },
                    { new Guid("8dd10184-a706-4978-9635-9a3994650c6f"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Config",
                columns: new[] { "ConfigId", "Key", "Value" },
                values: new object[] { new Guid("5dc06ca2-403a-4628-9207-0278a5b2d6b5"), "maxBorrowDaysAllowed", "30" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("9362cdf6-6d96-43f9-8fe3-5f8e3cdb8797"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 25, 45, 427, DateTimeKind.Local).AddTicks(6733), "Lorem ipsum dolor sit amet", null },
                    { new Guid("05976cbc-f50b-42d2-aaf6-848668a3d9d1"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 25, 45, 430, DateTimeKind.Local).AddTicks(939), "Lorem ipsum dolor sit amet", null },
                    { new Guid("21ea9c42-b950-4a23-9a26-ce2a836ffc10"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 25, 45, 430, DateTimeKind.Local).AddTicks(990), "Lorem ipsum dolor sit amet", null },
                    { new Guid("1e8b074f-ef1b-41b6-aa9c-d4c24ad780c2"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 25, 45, 430, DateTimeKind.Local).AddTicks(1033), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("483a45d9-3743-42d6-a1ee-6f37f05ab97d"), "Broń" },
                    { new Guid("92227a5b-8bf2-464f-983f-36cbda238e9b"), "Magia" },
                    { new Guid("e8c4fab7-dd7d-4328-8b45-aff3d5d2222a"), "Krew" },
                    { new Guid("6268d369-fef0-4d26-8ea8-9280c2a98c08"), "Psychologiczne" },
                    { new Guid("0a9cb226-5d3e-4e0f-8093-c9fc55daa1ac"), "Historia polska" },
                    { new Guid("cad8d076-023c-4b40-b61d-ce7ae3ee5eb9"), "Historia zagraniczna" }
                });
        }
    }
}
