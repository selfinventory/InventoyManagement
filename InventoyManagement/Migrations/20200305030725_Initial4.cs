using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoyManagement.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartsFotoCreated",
                table: "PartsFoto");

            migrationBuilder.DropColumn(
                name: "PartsFotoUpdate",
                table: "PartsFoto");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PartsFoto",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "PartsFoto",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Invoices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PartsFoto");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "PartsFoto");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Invoices");

            migrationBuilder.AddColumn<DateTime>(
                name: "PartsFotoCreated",
                table: "PartsFoto",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PartsFotoUpdate",
                table: "PartsFoto",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
