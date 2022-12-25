using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class RemoveBorrowCartDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCartItems_BorrowCarts_BorrowCartId",
                table: "BorrowCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCarts_AspNetUsers_UserEntityId",
                table: "BorrowCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowCarts",
                table: "BorrowCarts");

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

            migrationBuilder.RenameTable(
                name: "BorrowCarts",
                newName: "BorrowCart");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowCarts_UserEntityId",
                table: "BorrowCart",
                newName: "IX_BorrowCart_UserEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowCart",
                table: "BorrowCart",
                column: "BorrowCartId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("b4a8f01c-2267-4027-8428-816d105751b7"), "Fantastyka" },
                    { new Guid("f29291ed-c689-42e6-9f15-44b35343e294"), "Horror" },
                    { new Guid("670dd0fb-da5e-4105-8246-7456200b1090"), "Sci-Fi" },
                    { new Guid("0289a089-7ba0-432e-85af-f7008a45e49c"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("cbaf7ce6-ea51-4c46-a260-277f0d70234c"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 54, 43, 952, DateTimeKind.Local).AddTicks(4698), "Lorem ipsum dolor sit amet", null },
                    { new Guid("c94de6d9-c9b0-49cb-ac96-44b6cbf539e0"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 54, 43, 955, DateTimeKind.Local).AddTicks(916), "Lorem ipsum dolor sit amet", null },
                    { new Guid("8ace8f86-9cac-4617-832f-1f47f40ee3a6"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 54, 43, 955, DateTimeKind.Local).AddTicks(966), "Lorem ipsum dolor sit amet", null },
                    { new Guid("6cb795bd-e729-4538-951e-b50c9b4d3e19"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 22, 54, 43, 955, DateTimeKind.Local).AddTicks(990), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("185ef860-7232-4865-a46b-8f1d016f3553"), "Broń" },
                    { new Guid("29421ec5-02ab-45c1-b799-ce239d5747aa"), "Magia" },
                    { new Guid("6038d1db-8ab0-485d-9363-25ff9bda0c2e"), "Krew" },
                    { new Guid("6e968245-e9f3-40bf-bd36-973199eec854"), "Psychologiczne" },
                    { new Guid("ab2b0992-9405-4e79-a1cd-fdc09dd6f61c"), "Historia polska" },
                    { new Guid("47ae1dcb-bf9c-40a4-814a-012077856011"), "Historia zagraniczna" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowCart_AspNetUsers_UserEntityId",
                table: "BorrowCart",
                column: "UserEntityId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowCartItems_BorrowCart_BorrowCartId",
                table: "BorrowCartItems",
                column: "BorrowCartId",
                principalTable: "BorrowCart",
                principalColumn: "BorrowCartId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCart_AspNetUsers_UserEntityId",
                table: "BorrowCart");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCartItems_BorrowCart_BorrowCartId",
                table: "BorrowCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowCart",
                table: "BorrowCart");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0289a089-7ba0-432e-85af-f7008a45e49c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("670dd0fb-da5e-4105-8246-7456200b1090"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b4a8f01c-2267-4027-8428-816d105751b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f29291ed-c689-42e6-9f15-44b35343e294"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("6cb795bd-e729-4538-951e-b50c9b4d3e19"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("8ace8f86-9cac-4617-832f-1f47f40ee3a6"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("c94de6d9-c9b0-49cb-ac96-44b6cbf539e0"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("cbaf7ce6-ea51-4c46-a260-277f0d70234c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("185ef860-7232-4865-a46b-8f1d016f3553"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("29421ec5-02ab-45c1-b799-ce239d5747aa"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("47ae1dcb-bf9c-40a4-814a-012077856011"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6038d1db-8ab0-485d-9363-25ff9bda0c2e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6e968245-e9f3-40bf-bd36-973199eec854"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("ab2b0992-9405-4e79-a1cd-fdc09dd6f61c"));

            migrationBuilder.RenameTable(
                name: "BorrowCart",
                newName: "BorrowCarts");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowCart_UserEntityId",
                table: "BorrowCarts",
                newName: "IX_BorrowCarts_UserEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowCarts",
                table: "BorrowCarts",
                column: "BorrowCartId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowCartItems_BorrowCarts_BorrowCartId",
                table: "BorrowCartItems",
                column: "BorrowCartId",
                principalTable: "BorrowCarts",
                principalColumn: "BorrowCartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowCarts_AspNetUsers_UserEntityId",
                table: "BorrowCarts",
                column: "UserEntityId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
