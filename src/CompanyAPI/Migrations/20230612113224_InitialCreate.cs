using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockEntry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Product 1", "Product 1", 1.99 },
                    { 2, "Product 2", "Product 2", 2.9900000000000002 },
                    { 3, "Product 3", "Product 3", 3.9900000000000002 },
                    { 4, "Product 4", "Product 4", 4.9900000000000002 },
                    { 5, "Product 5", "Product 5", 5.9900000000000002 }
                });

            migrationBuilder.InsertData(
                table: "StockEntry",
                columns: new[] { "Id", "ProductId", "Quantity", "StoreId" },
                values: new object[,]
                {
                    { 1, 1, 10, 1 },
                    { 2, 2, 10, 1 },
                    { 3, 3, 10, 1 },
                    { 4, 4, 10, 1 },
                    { 5, 5, 10, 1 },
                    { 6, 1, 10, 2 },
                    { 7, 2, 10, 2 },
                    { 8, 3, 10, 2 },
                    { 9, 4, 10, 2 },
                    { 10, 5, 10, 2 },
                    { 11, 1, 10, 3 },
                    { 12, 2, 10, 3 },
                    { 13, 3, 10, 3 },
                    { 14, 4, 10, 3 },
                    { 15, 5, 10, 3 },
                    { 16, 1, 10, 4 },
                    { 17, 2, 10, 4 },
                    { 18, 3, 10, 4 },
                    { 19, 4, 10, 4 },
                    { 20, 5, 10, 4 },
                    { 21, 1, 10, 5 },
                    { 22, 2, 10, 5 },
                    { 23, 3, 10, 5 },
                    { 24, 4, 10, 5 },
                    { 25, 5, 10, 5 }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "CloseTime", "Location", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Location 1", "Store 1", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Location 2", "Store 2", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Location 3", "Store 3", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Location 4", "Store 4", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Location 5", "Store 5", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "StockEntry");

            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
