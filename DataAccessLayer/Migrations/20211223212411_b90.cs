using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class b90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_AuthorId",
                table: "Abouts",
                column: "AuthorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Authors_AuthorId",
                table: "Abouts",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Authors_AuthorId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_AuthorId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Comments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
