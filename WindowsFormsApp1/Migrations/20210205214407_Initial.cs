using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    UserPassword = table.Column<string>(nullable: false),
                    UserRight = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ArendaObjects",
                columns: table => new
                {
                    ArendaObjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectName = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    HouseNumber = table.Column<int>(nullable: false),
                    ApartmentNumber = table.Column<int>(nullable: true),
                    HouseArea = table.Column<double>(nullable: true),
                    NumberRoom = table.Column<int>(nullable: true),
                    Floor = table.Column<int>(nullable: true),
                    Owner = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArendaObjects", x => x.ArendaObjectId);
                    table.ForeignKey(
                        name: "FK_ArendaObjects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    ThirdName = table.Column<string>(nullable: false),
                    Phone_1 = table.Column<string>(nullable: false),
                    Phone_2 = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Lease_date = table.Column<DateTime>(nullable: false),
                    Rent_price = table.Column<decimal>(nullable: false),
                    Pledge = table.Column<decimal>(nullable: false),
                    Series_passport = table.Column<int>(nullable: false),
                    Number_passport = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.TenantId);
                    table.ForeignKey(
                        name: "FK_Tenants_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArendaObjects_UserId",
                table: "ArendaObjects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_UserId",
                table: "Tenants",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArendaObjects");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
