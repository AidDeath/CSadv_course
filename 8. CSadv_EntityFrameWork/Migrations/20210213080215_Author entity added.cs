using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCoreExample.Migrations
{
    public partial class Authorentityadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Stories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorSurname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "AuthorName", "AuthorSurname" },
                values: new object[] { 1, "Isaak", "Azimov" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "AuthorName", "AuthorSurname" },
                values: new object[] { 2, "Johr Ronald Ruel", "Talkien" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "AuthorName", "AuthorSurname" },
                values: new object[] { 3, "Dan", "Simmons" });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Author_AuthorId",
                table: "Stories",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Author_AuthorId",
                table: "Stories");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Stories");
        }
    }
}
