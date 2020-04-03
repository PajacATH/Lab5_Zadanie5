using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5_Zadanie5.Migrations
{
    public partial class Mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "Band",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "Band");
        }
    }
}
