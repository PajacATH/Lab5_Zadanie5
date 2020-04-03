using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5_Zadanie5.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_City_CityID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Band_ID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Band_BandID",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Band",
                table: "Band");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Band");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "BandID",
                table: "Event",
                newName: "BandId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_BandID",
                table: "Event",
                newName: "IX_Event_BandId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CityID",
                table: "Address",
                newName: "IX_Address_CityID");

            migrationBuilder.AddColumn<int>(
                name: "BandId",
                table: "Band",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "Address",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Band",
                table: "Band",
                column: "BandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AdresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Band_AdresId",
                table: "Address",
                column: "AdresId",
                principalTable: "Band",
                principalColumn: "BandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_City_CityID",
                table: "Address",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Band_BandId",
                table: "Event",
                column: "BandId",
                principalTable: "Band",
                principalColumn: "BandId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Band_AdresId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_City_CityID",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Band_BandId",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Band",
                table: "Band");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Band");

            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameColumn(
                name: "BandId",
                table: "Event",
                newName: "BandID");

            migrationBuilder.RenameIndex(
                name: "IX_Event_BandId",
                table: "Event",
                newName: "IX_Event_BandID");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CityID",
                table: "Addresses",
                newName: "IX_Addresses_CityID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Band",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Band",
                table: "Band",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_City_CityID",
                table: "Addresses",
                column: "CityID",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Band_ID",
                table: "Addresses",
                column: "ID",
                principalTable: "Band",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Band_BandID",
                table: "Event",
                column: "BandID",
                principalTable: "Band",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
