using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoyManagement.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerStatus",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CompanyStatus",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "PartsRackNo",
                table: "Parts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Companies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartsRackNo",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "CustomerStatus",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CompanyStatus",
                table: "Companies",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
