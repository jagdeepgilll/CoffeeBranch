using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeBranch.Migrations
{
    public partial class testttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flavour",
                table: "Menu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Flavour",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
