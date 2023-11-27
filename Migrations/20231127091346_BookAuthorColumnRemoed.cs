using Microsoft.EntityFrameworkCore.Migrations;

namespace Libreria_DGGR.Migrations
{
    public partial class BookAuthorColumnRemoed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
