using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaMVCApp.Migrations
{
    public partial class DeletedNotUsedEntites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookEntityTagEntity");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "QueueEntityUserEntity");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Queues");

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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("52b218ce-ea6c-4367-bb60-d56e7f7d7226"), "Fantastyka" },
                    { new Guid("755439c5-999d-49ba-ae6c-cf3cb60ac47c"), "Horror" },
                    { new Guid("19eda284-5dfc-4602-b375-accf2461c8b5"), "Sci-Fi" },
                    { new Guid("885cdaee-19f8-4b99-83e2-3503a8c09ace"), "Historyczne" }
                });

            migrationBuilder.InsertData(
                table: "Config",
                columns: new[] { "ConfigId", "Key", "Value" },
                values: new object[,]
                {
                    { new Guid("5d4d9909-64c4-4252-955a-57c75bad268b"), "maxBorrowDaysAllowed", "30" },
                    { new Guid("ac0c2b9b-52b5-4ca4-ab97-77ffc0edf825"), "maxDaysToRetrieve", "3" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("b2a6cd72-e62b-4257-b8f2-9819cd427431"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 21, 14, 47, 13, 843, DateTimeKind.Local).AddTicks(8586), "Lorem ipsum dolor sit amet", null },
                    { new Guid("24d7f519-a16b-4c45-b18a-b2173c71c065"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 21, 14, 47, 13, 846, DateTimeKind.Local).AddTicks(3618), "Lorem ipsum dolor sit amet", null },
                    { new Guid("ba435d75-c999-4086-b98a-4603e0bd70d0"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 21, 14, 47, 13, 846, DateTimeKind.Local).AddTicks(3666), "Lorem ipsum dolor sit amet", null },
                    { new Guid("2bf0f9b5-0b10-4a61-82b7-1d085a76b6fc"), "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.", new DateTime(2023, 1, 21, 14, 47, 13, 846, DateTimeKind.Local).AddTicks(3696), "Lorem ipsum dolor sit amet", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("19eda284-5dfc-4602-b375-accf2461c8b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("52b218ce-ea6c-4367-bb60-d56e7f7d7226"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("755439c5-999d-49ba-ae6c-cf3cb60ac47c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("885cdaee-19f8-4b99-83e2-3503a8c09ace"));

            migrationBuilder.DeleteData(
                table: "Config",
                keyColumn: "ConfigId",
                keyValue: new Guid("5d4d9909-64c4-4252-955a-57c75bad268b"));

            migrationBuilder.DeleteData(
                table: "Config",
                keyColumn: "ConfigId",
                keyValue: new Guid("ac0c2b9b-52b5-4ca4-ab97-77ffc0edf825"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("24d7f519-a16b-4c45-b18a-b2173c71c065"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("2bf0f9b5-0b10-4a61-82b7-1d085a76b6fc"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("b2a6cd72-e62b-4257-b8f2-9819cd427431"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("ba435d75-c999-4086-b98a-4603e0bd70d0"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    QueueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queues", x => x.QueueId);
                    table.ForeignKey(
                        name: "FK_Queues_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BorrowCartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForfeitValue = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_BorrowCartItems_BorrowCartItemId",
                        column: x => x.BorrowCartItemId,
                        principalTable: "BorrowCartItems",
                        principalColumn: "BorrowCartItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QueueEntityUserEntity",
                columns: table => new
                {
                    QueuesQueueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueEntityUserEntity", x => new { x.QueuesQueueId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_QueueEntityUserEntity_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QueueEntityUserEntity_Queues_QueuesQueueId",
                        column: x => x.QueuesQueueId,
                        principalTable: "Queues",
                        principalColumn: "QueueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookEntityTagEntity",
                columns: table => new
                {
                    BooksBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsTagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEntityTagEntity", x => new { x.BooksBookId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_BookEntityTagEntity_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookEntityTagEntity_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BookEntityTagEntity_TagsTagId",
                table: "BookEntityTagEntity",
                column: "TagsTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_BookId",
                table: "Files",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_QueueEntityUserEntity_UsersId",
                table: "QueueEntityUserEntity",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Queues_BookId",
                table: "Queues",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BorrowCartItemId",
                table: "Tickets",
                column: "BorrowCartItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");
        }
    }
}
