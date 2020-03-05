using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoyManagement.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelParts_Brands_ModelPartsBrandsBrandID",
                table: "ModelParts");

            migrationBuilder.DropForeignKey(
                name: "FK_PartsGroup_ModelParts_PartsGroupModelIDModelPartsID",
                table: "PartsGroup");

            migrationBuilder.DropIndex(
                name: "IX_PartsGroup_PartsGroupModelIDModelPartsID",
                table: "PartsGroup");

            migrationBuilder.DropIndex(
                name: "IX_ModelParts_ModelPartsBrandsBrandID",
                table: "ModelParts");

            migrationBuilder.DropColumn(
                name: "PartsGroupModelIDModelPartsID",
                table: "PartsGroup");

            migrationBuilder.DropColumn(
                name: "ModelPartsBrandsBrandID",
                table: "ModelParts");

            migrationBuilder.AddColumn<string>(
                name: "ModelPartsModelModelPartsID",
                table: "PartsGroup",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartsManufactureYear",
                table: "Parts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrandsModelBrandID",
                table: "ModelParts",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyRegistrationID",
                table: "Companies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    TaxID = table.Column<string>(nullable: false),
                    TaxDesc = table.Column<string>(nullable: true),
                    TaxAmount = table.Column<float>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    TaxStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.TaxID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartsGroup_ModelPartsModelModelPartsID",
                table: "PartsGroup",
                column: "ModelPartsModelModelPartsID");

            migrationBuilder.CreateIndex(
                name: "IX_ModelParts_BrandsModelBrandID",
                table: "ModelParts",
                column: "BrandsModelBrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelParts_Brands_BrandsModelBrandID",
                table: "ModelParts",
                column: "BrandsModelBrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartsGroup_ModelParts_ModelPartsModelModelPartsID",
                table: "PartsGroup",
                column: "ModelPartsModelModelPartsID",
                principalTable: "ModelParts",
                principalColumn: "ModelPartsID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelParts_Brands_BrandsModelBrandID",
                table: "ModelParts");

            migrationBuilder.DropForeignKey(
                name: "FK_PartsGroup_ModelParts_ModelPartsModelModelPartsID",
                table: "PartsGroup");

            migrationBuilder.DropTable(
                name: "Tax");

            migrationBuilder.DropIndex(
                name: "IX_PartsGroup_ModelPartsModelModelPartsID",
                table: "PartsGroup");

            migrationBuilder.DropIndex(
                name: "IX_ModelParts_BrandsModelBrandID",
                table: "ModelParts");

            migrationBuilder.DropColumn(
                name: "ModelPartsModelModelPartsID",
                table: "PartsGroup");

            migrationBuilder.DropColumn(
                name: "PartsManufactureYear",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "BrandsModelBrandID",
                table: "ModelParts");

            migrationBuilder.AddColumn<string>(
                name: "PartsGroupModelIDModelPartsID",
                table: "PartsGroup",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModelPartsBrandsBrandID",
                table: "ModelParts",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyRegistrationID",
                table: "Companies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_PartsGroup_PartsGroupModelIDModelPartsID",
                table: "PartsGroup",
                column: "PartsGroupModelIDModelPartsID");

            migrationBuilder.CreateIndex(
                name: "IX_ModelParts_ModelPartsBrandsBrandID",
                table: "ModelParts",
                column: "ModelPartsBrandsBrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelParts_Brands_ModelPartsBrandsBrandID",
                table: "ModelParts",
                column: "ModelPartsBrandsBrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartsGroup_ModelParts_PartsGroupModelIDModelPartsID",
                table: "PartsGroup",
                column: "PartsGroupModelIDModelPartsID",
                principalTable: "ModelParts",
                principalColumn: "ModelPartsID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
