using Microsoft.EntityFrameworkCore.Migrations;

namespace NavEcommerce.Migrations
{
    public partial class m2mpayload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_Brands_brandsId",
                table: "Motorcycles");

            migrationBuilder.DropIndex(
                name: "IX_Motorcycles_brandsId",
                table: "Motorcycles");

            migrationBuilder.DropColumn(
                name: "brandsId",
                table: "Motorcycles");

            migrationBuilder.CreateTable(
                name: "BrandMotorcycle",
                columns: table => new
                {
                    MotorcycleId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Dealers = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandMotorcycle", x => new { x.BrandId, x.MotorcycleId });
                    table.ForeignKey(
                        name: "FK_BrandMotorcycle_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandMotorcycle_Motorcycles_MotorcycleId",
                        column: x => x.MotorcycleId,
                        principalTable: "Motorcycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandMotorcycle_MotorcycleId",
                table: "BrandMotorcycle",
                column: "MotorcycleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandMotorcycle");

            migrationBuilder.AddColumn<int>(
                name: "brandsId",
                table: "Motorcycles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_brandsId",
                table: "Motorcycles",
                column: "brandsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_Brands_brandsId",
                table: "Motorcycles",
                column: "brandsId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
