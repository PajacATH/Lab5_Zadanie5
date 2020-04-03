using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5_Zadanie5.Migrations
{
    public partial class Mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Address",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityID",
                table: "Address",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_City_CityID",
                table: "Address",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_City_CityID",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_CityID",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Address");
        }
    }
}
