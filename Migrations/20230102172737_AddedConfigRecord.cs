using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class AddedConfigRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("e67e72b4-0bcb-4b6a-b157-b9647c103f03"), "Fantastyka" },
                    { new Guid("413f4dd8-a46f-4350-87dc-bf9ef5186a74"), "Horror" },
                    { new Guid("cff267d6-5dc3-40d8-8e35-7070123ec4c7"), "Sci-Fi" },
                    { new Guid("63e20408-7322-49be-b6d6-8253f4de9f20"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Config",
                columns: new[] { "ConfigId", "Key", "Value" },
                values: new object[,]
                {
                    { new Guid("a1267e87-d251-43f8-8ea2-8f4899cd91a3"), "maxBorrowDaysAllowed", "30" },
                    { new Guid("14bf5464-4bb8-4323-b47e-d3251dab4912"), "maxDaysToRetrieve", "3" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("16901b8a-b95b-49af-8bc2-e46677408d64"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 18, 27, 36, 577, DateTimeKind.Local).AddTicks(3572), "Lorem ipsum dolor sit amet", null },
                    { new Guid("dd582928-9007-4081-8645-15d0e7700ff7"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 18, 27, 36, 579, DateTimeKind.Local).AddTicks(8155), "Lorem ipsum dolor sit amet", null },
                    { new Guid("bd0b5852-ecef-4544-af7b-d0d62ec0822e"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 18, 27, 36, 579, DateTimeKind.Local).AddTicks(8215), "Lorem ipsum dolor sit amet", null },
                    { new Guid("203dce64-83a7-4c6e-96f4-a28b9da34127"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 2, 18, 27, 36, 579, DateTimeKind.Local).AddTicks(8239), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("2bedf338-94f4-49da-8afb-ab404de2cda5"), "Broń" },
                    { new Guid("b4d12838-3d93-42ba-8c25-3c847f49f835"), "Magia" },
                    { new Guid("2c196d5b-c7dd-48d8-a6e8-a5f9c1ff7144"), "Krew" },
                    { new Guid("ebc8d53d-23a0-42d6-9eda-4dbe8db99a80"), "Psychologiczne" },
                    { new Guid("39519bb7-237f-4ad4-a25f-416651ce7e9a"), "Historia polska" },
                    { new Guid("1b425130-b817-467a-b939-d95fc8ee43f0"), "Historia zagraniczna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("413f4dd8-a46f-4350-87dc-bf9ef5186a74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("63e20408-7322-49be-b6d6-8253f4de9f20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cff267d6-5dc3-40d8-8e35-7070123ec4c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e67e72b4-0bcb-4b6a-b157-b9647c103f03"));

            migrationBuilder.DeleteData(
                table: "Config",
                keyColumn: "ConfigId",
                keyValue: new Guid("14bf5464-4bb8-4323-b47e-d3251dab4912"));

            migrationBuilder.DeleteData(
                table: "Config",
                keyColumn: "ConfigId",
                keyValue: new Guid("a1267e87-d251-43f8-8ea2-8f4899cd91a3"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("16901b8a-b95b-49af-8bc2-e46677408d64"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("203dce64-83a7-4c6e-96f4-a28b9da34127"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("bd0b5852-ecef-4544-af7b-d0d62ec0822e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("dd582928-9007-4081-8645-15d0e7700ff7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("1b425130-b817-467a-b939-d95fc8ee43f0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("2bedf338-94f4-49da-8afb-ab404de2cda5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("2c196d5b-c7dd-48d8-a6e8-a5f9c1ff7144"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("39519bb7-237f-4ad4-a25f-416651ce7e9a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("b4d12838-3d93-42ba-8c25-3c847f49f835"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("ebc8d53d-23a0-42d6-9eda-4dbe8db99a80"));

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
    }
}
