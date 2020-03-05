using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoyManagement.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CostValue",
                table: "Invoices",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DiscountValue",
                table: "Invoices",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TaxPercentage",
                table: "Invoices",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TaxValue",
                table: "Invoices",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CustomerStatus",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyStatus",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<string>(nullable: false),
                    BrandName = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    BrandStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Labor",
                columns: table => new
                {
                    LaborId = table.Column<string>(nullable: false),
                    LaborDesc = table.Column<string>(nullable: true),
                    LaborPrice = table.Column<float>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    LaborStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labor", x => x.LaborId);
                });

            migrationBuilder.CreateTable(
                name: "PartsFoto",
                columns: table => new
                {
                    PartsFotoID = table.Column<string>(nullable: false),
                    PartsFotoDesc = table.Column<string>(nullable: true),
                    PartsFotoCreated = table.Column<DateTime>(nullable: false),
                    PartsFotoUpdate = table.Column<DateTime>(nullable: false),
                    PartsStatusImage = table.Column<byte[]>(nullable: true),
                    PartsFotoStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartsFoto", x => x.PartsFotoID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMode",
                columns: table => new
                {
                    PaymentTypeid = table.Column<string>(nullable: false),
                    PaymentTypeDesc = table.Column<string>(nullable: true),
                    PaymentTypeStatus = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMode", x => x.PaymentTypeid);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierRegistrationID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(nullable: false),
                    SupplierAdd1 = table.Column<string>(nullable: false),
                    SupplierAdd2 = table.Column<string>(nullable: true),
                    SupplierAdd3 = table.Column<string>(nullable: true),
                    SupplierAdd4 = table.Column<string>(nullable: true),
                    SupplierCity = table.Column<string>(nullable: false),
                    SupplierState = table.Column<string>(nullable: false),
                    SupplierCounty = table.Column<string>(nullable: true),
                    SupplierEmail = table.Column<string>(nullable: true),
                    SupplierTelOffice = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    SupplierStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierRegistrationID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<string>(nullable: false),
                    UserInfo = table.Column<string>(nullable: true),
                    UserPassword = table.Column<byte[]>(nullable: true),
                    Retry = table.Column<int>(nullable: false),
                    LoginDate = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    UserGroup = table.Column<int>(nullable: false),
                    UserStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "ModelParts",
                columns: table => new
                {
                    ModelPartsID = table.Column<string>(nullable: false),
                    ModelPartsDesc = table.Column<string>(nullable: true),
                    ModelPartsYear = table.Column<string>(nullable: true),
                    ModelPartsCC = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    ModelPartsBrandsBrandID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelParts", x => x.ModelPartsID);
                    table.ForeignKey(
                        name: "FK_ModelParts_Brands_ModelPartsBrandsBrandID",
                        column: x => x.ModelPartsBrandsBrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Finances",
                columns: table => new
                {
                    FinanceGLID = table.Column<string>(nullable: false),
                    FinanceGLDesc = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    SupplierInfoSupplierRegistrationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finances", x => x.FinanceGLID);
                    table.ForeignKey(
                        name: "FK_Finances_Suppliers_SupplierInfoSupplierRegistrationID",
                        column: x => x.SupplierInfoSupplierRegistrationID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierRegistrationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartsGroup",
                columns: table => new
                {
                    PartsGroupID = table.Column<string>(nullable: false),
                    PartsGroupDesc = table.Column<string>(nullable: true),
                    PartsGroupImage = table.Column<byte[]>(nullable: true),
                    PartsGroupModelIDModelPartsID = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    PartsStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartsGroup", x => x.PartsGroupID);
                    table.ForeignKey(
                        name: "FK_PartsGroup_ModelParts_PartsGroupModelIDModelPartsID",
                        column: x => x.PartsGroupModelIDModelPartsID,
                        principalTable: "ModelParts",
                        principalColumn: "ModelPartsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PartsID = table.Column<string>(nullable: false),
                    PartsDesc = table.Column<string>(nullable: true),
                    PartsQty = table.Column<string>(nullable: true),
                    PartsPrice = table.Column<string>(nullable: true),
                    PartsSellPrice = table.Column<string>(nullable: true),
                    FinanceInfoFinanceGLID = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: true),
                    PartsStatus = table.Column<int>(nullable: false),
                    PartsGroupModelPartsGroupID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartsID);
                    table.ForeignKey(
                        name: "FK_Parts_Finances_FinanceInfoFinanceGLID",
                        column: x => x.FinanceInfoFinanceGLID,
                        principalTable: "Finances",
                        principalColumn: "FinanceGLID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parts_PartsGroup_PartsGroupModelPartsGroupID",
                        column: x => x.PartsGroupModelPartsGroupID,
                        principalTable: "PartsGroup",
                        principalColumn: "PartsGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Finances_SupplierInfoSupplierRegistrationID",
                table: "Finances",
                column: "SupplierInfoSupplierRegistrationID");

            migrationBuilder.CreateIndex(
                name: "IX_ModelParts_ModelPartsBrandsBrandID",
                table: "ModelParts",
                column: "ModelPartsBrandsBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_FinanceInfoFinanceGLID",
                table: "Parts",
                column: "FinanceInfoFinanceGLID");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_PartsGroupModelPartsGroupID",
                table: "Parts",
                column: "PartsGroupModelPartsGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_PartsGroup_PartsGroupModelIDModelPartsID",
                table: "PartsGroup",
                column: "PartsGroupModelIDModelPartsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Labor");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "PartsFoto");

            migrationBuilder.DropTable(
                name: "PaymentMode");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Finances");

            migrationBuilder.DropTable(
                name: "PartsGroup");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "ModelParts");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropColumn(
                name: "CostValue",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "DiscountValue",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "TaxPercentage",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "TaxValue",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CustomerStatus",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CompanyStatus",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Companies");
        }
    }
}
