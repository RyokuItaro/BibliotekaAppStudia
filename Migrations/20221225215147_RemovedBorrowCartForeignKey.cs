using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class RemovedBorrowCartForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5544affe-8486-46c9-83ad-896855eea5fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8264a945-6eae-4fe8-a193-ed029d056f24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("af6d9dfe-af0a-4230-ada3-6a4d066e7679"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bdf2784a-e3cb-480c-8b7a-6466390c4e62"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("5d86ec9b-03d7-48c3-9325-0b22dfae169a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("5fa98244-ed22-4407-b47c-536197ccb98e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("8cca1623-399e-484b-9119-448c5dac0bd3"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("981e1a85-b0d3-46e2-ae90-53c8c614b727"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("51a761b8-8104-41e0-9213-7cfbbca41f54"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("609f6c46-6f32-4b8a-92b2-8798e8215354"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6fa2e8c9-ad41-4e8e-824a-4b2bde385c92"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("75f3f2d4-2cab-4752-bfe3-40a5beba14c6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("a5f710fa-8914-4bc8-9108-bb82a2b4328d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("cb75a5b6-98ed-4810-b6f3-6ac32b2aa2d8"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("73ee980c-b334-4ff2-aeda-e8126fef8ff4"), "Fantastyka" },
                    { new Guid("d6455626-6db3-46e3-8952-90c202a21acb"), "Horror" },
                    { new Guid("bc0f2e92-ad7d-4a3a-b1d8-bd8ff4f56453"), "Sci-Fi" },
                    { new Guid("92de880c-930c-4176-aa79-1d18da366af3"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("01a2f7ed-883d-4e94-b1b1-737adc726888"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 51, 46, 615, DateTimeKind.Local).AddTicks(4625), "Lorem ipsum dolor sit amet", null },
                    { new Guid("ff8ef36d-298c-4b94-969c-ab678fc1fdbc"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 51, 46, 618, DateTimeKind.Local).AddTicks(1804), "Lorem ipsum dolor sit amet", null },
                    { new Guid("93d924c5-ec56-4cfb-aba4-c4b17904e7ef"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 51, 46, 618, DateTimeKind.Local).AddTicks(1856), "Lorem ipsum dolor sit amet", null },
                    { new Guid("534a8615-e282-4c3c-8a5a-73b3def1fafe"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 51, 46, 618, DateTimeKind.Local).AddTicks(1880), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("b51f8329-68d3-477d-b096-e5fb890bbd34"), "Broń" },
                    { new Guid("c9b276b3-5f89-45fe-bb03-fb3bbec647ad"), "Magia" },
                    { new Guid("b5a3016b-2877-4c63-9e05-2e87f3631c42"), "Krew" },
                    { new Guid("7107b0c7-2a74-40ca-b56f-4b6b08c0a34a"), "Psychologiczne" },
                    { new Guid("5f569973-526d-4089-82dd-ac82f6ff01a2"), "Historia polska" },
                    { new Guid("767d857c-2cf1-4d50-b9fa-487325cdaea7"), "Historia zagraniczna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("73ee980c-b334-4ff2-aeda-e8126fef8ff4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("92de880c-930c-4176-aa79-1d18da366af3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bc0f2e92-ad7d-4a3a-b1d8-bd8ff4f56453"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d6455626-6db3-46e3-8952-90c202a21acb"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("01a2f7ed-883d-4e94-b1b1-737adc726888"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("534a8615-e282-4c3c-8a5a-73b3def1fafe"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("93d924c5-ec56-4cfb-aba4-c4b17904e7ef"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("ff8ef36d-298c-4b94-969c-ab678fc1fdbc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("5f569973-526d-4089-82dd-ac82f6ff01a2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("7107b0c7-2a74-40ca-b56f-4b6b08c0a34a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("767d857c-2cf1-4d50-b9fa-487325cdaea7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("b51f8329-68d3-477d-b096-e5fb890bbd34"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("b5a3016b-2877-4c63-9e05-2e87f3631c42"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("c9b276b3-5f89-45fe-bb03-fb3bbec647ad"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("af6d9dfe-af0a-4230-ada3-6a4d066e7679"), "Fantastyka" },
                    { new Guid("5544affe-8486-46c9-83ad-896855eea5fc"), "Horror" },
                    { new Guid("bdf2784a-e3cb-480c-8b7a-6466390c4e62"), "Sci-Fi" },
                    { new Guid("8264a945-6eae-4fe8-a193-ed029d056f24"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("981e1a85-b0d3-46e2-ae90-53c8c614b727"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 31, 32, 972, DateTimeKind.Local).AddTicks(8999), "Lorem ipsum dolor sit amet", null },
                    { new Guid("8cca1623-399e-484b-9119-448c5dac0bd3"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 31, 32, 975, DateTimeKind.Local).AddTicks(3921), "Lorem ipsum dolor sit amet", null },
                    { new Guid("5d86ec9b-03d7-48c3-9325-0b22dfae169a"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 31, 32, 975, DateTimeKind.Local).AddTicks(3975), "Lorem ipsum dolor sit amet", null },
                    { new Guid("5fa98244-ed22-4407-b47c-536197ccb98e"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 31, 32, 975, DateTimeKind.Local).AddTicks(4001), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("6fa2e8c9-ad41-4e8e-824a-4b2bde385c92"), "Broń" },
                    { new Guid("a5f710fa-8914-4bc8-9108-bb82a2b4328d"), "Magia" },
                    { new Guid("51a761b8-8104-41e0-9213-7cfbbca41f54"), "Krew" },
                    { new Guid("cb75a5b6-98ed-4810-b6f3-6ac32b2aa2d8"), "Psychologiczne" },
                    { new Guid("75f3f2d4-2cab-4752-bfe3-40a5beba14c6"), "Historia polska" },
                    { new Guid("609f6c46-6f32-4b8a-92b2-8798e8215354"), "Historia zagraniczna" }
                });
        }
    }
}
