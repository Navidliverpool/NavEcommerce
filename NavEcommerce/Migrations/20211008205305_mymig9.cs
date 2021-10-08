using Microsoft.EntityFrameworkCore.Migrations;

namespace NavEcommerce.Migrations
{
    public partial class mymig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    DealerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.DealerId);
                });

            migrationBuilder.CreateTable(
                name: "Motorcycles",
                columns: table => new
                {
                    MotorcycleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycles", x => x.MotorcycleId);
                    table.ForeignKey(
                        name: "FK_Motorcycles_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BrandDealer",
                columns: table => new
                {
                    BrandsBrandId = table.Column<int>(type: "int", nullable: false),
                    DealersDealerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandDealer", x => new { x.BrandsBrandId, x.DealersDealerId });
                    table.ForeignKey(
                        name: "FK_BrandDealer_Brands_BrandsBrandId",
                        column: x => x.BrandsBrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandDealer_Dealers_DealersDealerId",
                        column: x => x.DealersDealerId,
                        principalTable: "Dealers",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DealerMotorcycle",
                columns: table => new
                {
                    DealersDealerId = table.Column<int>(type: "int", nullable: false),
                    MotorcyclesMotorcycleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerMotorcycle", x => new { x.DealersDealerId, x.MotorcyclesMotorcycleId });
                    table.ForeignKey(
                        name: "FK_DealerMotorcycle_Dealers_DealersDealerId",
                        column: x => x.DealersDealerId,
                        principalTable: "Dealers",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DealerMotorcycle_Motorcycles_MotorcyclesMotorcycleId",
                        column: x => x.MotorcyclesMotorcycleId,
                        principalTable: "Motorcycles",
                        principalColumn: "MotorcycleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandDealer_DealersDealerId",
                table: "BrandDealer",
                column: "DealersDealerId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerMotorcycle_MotorcyclesMotorcycleId",
                table: "DealerMotorcycle",
                column: "MotorcyclesMotorcycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_BrandId",
                table: "Motorcycles",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandDealer");

            migrationBuilder.DropTable(
                name: "DealerMotorcycle");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.DropTable(
                name: "Motorcycles");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
