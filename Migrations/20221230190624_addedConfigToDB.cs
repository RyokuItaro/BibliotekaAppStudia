using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class addedConfigToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0bfdbef3-d422-46e9-a643-174f7be6652b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1cd6d184-c443-4a59-b74a-873fdf849c1b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5ca01d66-b4fe-4007-a370-65524eadd7a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6f07eb4-70c6-42bd-84bb-45f0e194ee43"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("134b4e5d-63d8-41cc-acd0-56606995644e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("55c36856-7d45-42f5-86d9-fee05d647bef"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("7d2c0d1b-1de3-4d15-b11a-4bdd2abb67e9"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("ec223349-fd36-4213-b046-659a99d79043"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("048d4610-44be-4602-ba47-7d84f3971b40"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("3ae13f35-f6d2-4ab8-a5ea-987c73b48a50"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("90b733e5-ffba-45b5-b408-754ae1946bc8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("bea5091f-15f5-43fe-af27-09f712aa8668"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("cd9f8466-8ff1-4b68-a99a-252a88b76091"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("e58f0a00-4c6b-426b-909d-9f1dcead47a6"));

            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    ConfigId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.ConfigId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("5537f6d5-23a5-4cca-96ab-4b06b24b73e0"), "Fantastyka" },
                    { new Guid("ffaa6df0-33eb-4285-9f1b-8fee91c98316"), "Horror" },
                    { new Guid("7f21ec28-a31c-4958-9b4b-89ab5c3fa99a"), "Sci-Fi" },
                    { new Guid("2d1ef68f-11ed-41c7-8298-b453c3e5802e"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("889561aa-3dac-44f9-9c1e-695ecb359a39"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 6, 24, 215, DateTimeKind.Local).AddTicks(7119), "Lorem ipsum dolor sit amet", null },
                    { new Guid("1e1a7fe3-c2bf-4154-acb0-940e5784d4de"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 6, 24, 218, DateTimeKind.Local).AddTicks(5977), "Lorem ipsum dolor sit amet", null },
                    { new Guid("ebc3311a-692e-4cf6-8814-533167ee7788"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 6, 24, 218, DateTimeKind.Local).AddTicks(6029), "Lorem ipsum dolor sit amet", null },
                    { new Guid("3bab831f-9a49-4296-b445-f9d2750fdac1"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 30, 20, 6, 24, 218, DateTimeKind.Local).AddTicks(6156), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("c22ad7fb-f869-4a67-97fa-23f06bacc109"), "Broń" },
                    { new Guid("57b16cff-e359-43fb-a261-6f0a3979c512"), "Magia" },
                    { new Guid("2979ed13-c330-4c43-b61d-a53472ccf039"), "Krew" },
                    { new Guid("8a49323e-3747-4ce7-b301-39c498095580"), "Psychologiczne" },
                    { new Guid("8f95c9e5-b36e-406d-bb2e-a5df5e6a254e"), "Historia polska" },
                    { new Guid("9d1dbea5-2243-4158-af6c-6a96716d936e"), "Historia zagraniczna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d1ef68f-11ed-41c7-8298-b453c3e5802e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5537f6d5-23a5-4cca-96ab-4b06b24b73e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7f21ec28-a31c-4958-9b4b-89ab5c3fa99a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ffaa6df0-33eb-4285-9f1b-8fee91c98316"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("1e1a7fe3-c2bf-4154-acb0-940e5784d4de"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("3bab831f-9a49-4296-b445-f9d2750fdac1"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("889561aa-3dac-44f9-9c1e-695ecb359a39"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("ebc3311a-692e-4cf6-8814-533167ee7788"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("2979ed13-c330-4c43-b61d-a53472ccf039"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("57b16cff-e359-43fb-a261-6f0a3979c512"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("8a49323e-3747-4ce7-b301-39c498095580"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("8f95c9e5-b36e-406d-bb2e-a5df5e6a254e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("9d1dbea5-2243-4158-af6c-6a96716d936e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("c22ad7fb-f869-4a67-97fa-23f06bacc109"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("5ca01d66-b4fe-4007-a370-65524eadd7a1"), "Fantastyka" },
                    { new Guid("a6f07eb4-70c6-42bd-84bb-45f0e194ee43"), "Horror" },
                    { new Guid("1cd6d184-c443-4a59-b74a-873fdf849c1b"), "Sci-Fi" },
                    { new Guid("0bfdbef3-d422-46e9-a643-174f7be6652b"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d2c0d1b-1de3-4d15-b11a-4bdd2abb67e9"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 17, 40, 885, DateTimeKind.Local).AddTicks(5829), "Lorem ipsum dolor sit amet", null },
                    { new Guid("ec223349-fd36-4213-b046-659a99d79043"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 17, 40, 888, DateTimeKind.Local).AddTicks(545), "Lorem ipsum dolor sit amet", null },
                    { new Guid("134b4e5d-63d8-41cc-acd0-56606995644e"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 17, 40, 888, DateTimeKind.Local).AddTicks(593), "Lorem ipsum dolor sit amet", null },
                    { new Guid("55c36856-7d45-42f5-86d9-fee05d647bef"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2022, 12, 25, 23, 17, 40, 888, DateTimeKind.Local).AddTicks(618), "Lorem ipsum dolor sit amet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("048d4610-44be-4602-ba47-7d84f3971b40"), "Broń" },
                    { new Guid("90b733e5-ffba-45b5-b408-754ae1946bc8"), "Magia" },
                    { new Guid("e58f0a00-4c6b-426b-909d-9f1dcead47a6"), "Krew" },
                    { new Guid("cd9f8466-8ff1-4b68-a99a-252a88b76091"), "Psychologiczne" },
                    { new Guid("bea5091f-15f5-43fe-af27-09f712aa8668"), "Historia polska" },
                    { new Guid("3ae13f35-f6d2-4ab8-a5ea-987c73b48a50"), "Historia zagraniczna" }
                });
        }
    }
}
