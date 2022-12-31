using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class addDaystoReturnInBorrowedBookEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "DaysToReturn",
                table: "BorrowCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DaysToReturn",
                table: "BorrowCartItems");

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
    }
}
