using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class changedGuidToStringBecauseEFCoreIsStoopid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCartItems_BorrowCart_BorrowCartId",
                table: "BorrowCartItems");

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

            migrationBuilder.AlterColumn<string>(
                name: "BorrowCartId",
                table: "BorrowCartItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "BorrowCartId",
                table: "BorrowCart",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("1729150d-bfa4-4bbc-a31c-956432bb2a8a"), "Fantastyka" },
                    { new Guid("c25091d3-c0a9-425c-900d-87f638c10c8d"), "Horror" },
                    { new Guid("bf6313eb-d475-4760-9dfa-204e6ecaf994"), "Sci-Fi" },
                    { new Guid("eea3dc6b-2a76-41f0-9f6b-85a0a5a83a26"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("37b66ba9-8533-470c-8f1c-1a2e48291956"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 6, 1, 572, DateTimeKind.Local).AddTicks(5546), "Lorem ipsum dolor sit amet", null },
                    { new Guid("9f14da19-38a4-4f19-982b-42555afdfb28"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 6, 1, 575, DateTimeKind.Local).AddTicks(237), "Lorem ipsum dolor sit amet", null },
                    { new Guid("63a33c96-668c-42ed-b817-2a6f053b2e31"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 6, 1, 575, DateTimeKind.Local).AddTicks(285), "Lorem ipsum dolor sit amet", null },
                    { new Guid("a01e2b4a-090c-40c4-926a-ae4af1bc2a0f"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 6, 1, 575, DateTimeKind.Local).AddTicks(310), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("f5de8876-e524-4bb4-a572-fcc9e669a3d6"), "Broń" },
                    { new Guid("217b397f-b1c9-4f09-b34c-ecec8f52f505"), "Magia" },
                    { new Guid("6c885903-3f4b-4999-ae9a-16f06bf0871f"), "Krew" },
                    { new Guid("fd17090a-72ad-43ed-bd11-211d2fc03a62"), "Psychologiczne" },
                    { new Guid("b1af9fed-2203-454e-9478-486b5ba245ae"), "Historia polska" },
                    { new Guid("a96fd315-a708-44f8-b039-8bb9378b84df"), "Historia zagraniczna" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowCartItems_BorrowCart_BorrowCartId",
                table: "BorrowCartItems",
                column: "BorrowCartId",
                principalTable: "BorrowCart",
                principalColumn: "BorrowCartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowCartItems_BorrowCart_BorrowCartId",
                table: "BorrowCartItems");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1729150d-bfa4-4bbc-a31c-956432bb2a8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf6313eb-d475-4760-9dfa-204e6ecaf994"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c25091d3-c0a9-425c-900d-87f638c10c8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("eea3dc6b-2a76-41f0-9f6b-85a0a5a83a26"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("37b66ba9-8533-470c-8f1c-1a2e48291956"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("63a33c96-668c-42ed-b817-2a6f053b2e31"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("9f14da19-38a4-4f19-982b-42555afdfb28"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("a01e2b4a-090c-40c4-926a-ae4af1bc2a0f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("217b397f-b1c9-4f09-b34c-ecec8f52f505"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6c885903-3f4b-4999-ae9a-16f06bf0871f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("a96fd315-a708-44f8-b039-8bb9378b84df"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("b1af9fed-2203-454e-9478-486b5ba245ae"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("f5de8876-e524-4bb4-a572-fcc9e669a3d6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("fd17090a-72ad-43ed-bd11-211d2fc03a62"));

            migrationBuilder.AlterColumn<Guid>(
                name: "BorrowCartId",
                table: "BorrowCartItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BorrowCartId",
                table: "BorrowCart",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
                name: "FK_BorrowCartItems_BorrowCart_BorrowCartId",
                table: "BorrowCartItems",
                column: "BorrowCartId",
                principalTable: "BorrowCart",
                principalColumn: "BorrowCartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
