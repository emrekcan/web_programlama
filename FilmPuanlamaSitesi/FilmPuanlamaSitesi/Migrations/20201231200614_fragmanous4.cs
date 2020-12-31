using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmPuanlamaSitesi.Migrations
{
    public partial class fragmanous4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilmResim",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmResim",
                table: "Genres");
        }
    }
}
