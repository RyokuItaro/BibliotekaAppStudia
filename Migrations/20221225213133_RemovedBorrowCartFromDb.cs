using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class RemovedBorrowCartFromDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCarts_AspNetUsers_UserId",
                table: "BorrowCarts");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5c50cfb9-fdba-409b-aa0d-cd9a0355cc5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5fcd964e-a2f6-4441-b4b5-8cd51c820839"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8097a476-04b8-4aec-8b81-ac6ef046c532"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90499821-c488-4b73-9adf-077b1b051414"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("034ee422-b5e5-4f86-8c52-9baf382c3350"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("11714857-7a91-47ae-ad96-ac7ddb559473"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("69d249e1-c653-4540-9540-79c4d9b13d2a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("d7b6642d-e8d0-4dca-86a3-b37f0048be48"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("15bfcac1-ee96-4e4a-9343-67e249923968"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("296e4d5b-cce7-48df-a6c4-eb4797b1e9cc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("58fdf789-211b-4d11-a23c-2660aaa12f9f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("ab19c604-f166-4e03-84cc-54202dd09101"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("d2ef831a-612e-4f36-8f22-9d3d7c9a2bd2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("daedfd87-8e34-4dca-bd1c-67145092bf53"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "BorrowCarts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "BorrowCarts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BorrowCarts",
                newName: "UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowCarts_UserId",
                table: "BorrowCarts",
                newName: "IX_BorrowCarts_UserEntityId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowCarts_AspNetUsers_UserEntityId",
                table: "BorrowCarts",
                column: "UserEntityId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCarts_AspNetUsers_UserEntityId",
                table: "BorrowCarts");

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

            migrationBuilder.RenameColumn(
                name: "UserEntityId",
                table: "BorrowCarts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowCarts_UserEntityId",
                table: "BorrowCarts",
                newName: "IX_BorrowCarts_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "BorrowCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "BorrowCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("90499821-c488-4b73-9adf-077b1b051414"), "Fantastyka" },
                    { new Guid("5c50cfb9-fdba-409b-aa0d-cd9a0355cc5d"), "Horror" },
                    { new Guid("8097a476-04b8-4aec-8b81-ac6ef046c532"), "Sci-Fi" },
                    { new Guid("5fcd964e-a2f6-4441-b4b5-8cd51c820839"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("69d249e1-c653-4540-9540-79c4d9b13d2a"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 17, 14, 9, 15, 347, DateTimeKind.Local).AddTicks(387), "Lorem ipsum dolor sit amet", null },
                    { new Guid("034ee422-b5e5-4f86-8c52-9baf382c3350"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 17, 14, 9, 15, 349, DateTimeKind.Local).AddTicks(5390), "Lorem ipsum dolor sit amet", null },
                    { new Guid("d7b6642d-e8d0-4dca-86a3-b37f0048be48"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 17, 14, 9, 15, 349, DateTimeKind.Local).AddTicks(5437), "Lorem ipsum dolor sit amet", null },
                    { new Guid("11714857-7a91-47ae-ad96-ac7ddb559473"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 17, 14, 9, 15, 349, DateTimeKind.Local).AddTicks(5466), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("58fdf789-211b-4d11-a23c-2660aaa12f9f"), "Broń" },
                    { new Guid("15bfcac1-ee96-4e4a-9343-67e249923968"), "Magia" },
                    { new Guid("ab19c604-f166-4e03-84cc-54202dd09101"), "Krew" },
                    { new Guid("296e4d5b-cce7-48df-a6c4-eb4797b1e9cc"), "Psychologiczne" },
                    { new Guid("d2ef831a-612e-4f36-8f22-9d3d7c9a2bd2"), "Historia polska" },
                    { new Guid("daedfd87-8e34-4dca-bd1c-67145092bf53"), "Historia zagraniczna" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowCarts_AspNetUsers_UserId",
                table: "BorrowCarts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
