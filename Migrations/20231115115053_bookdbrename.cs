using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAPI.Migrations
{
    public partial class bookdbrename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "releaseDate",
                table: "Books",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "bookName",
                table: "Books",
                newName: "BookName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Books",
                newName: "releaseDate");

            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "Books",
                newName: "bookName");
        }
    }
}
