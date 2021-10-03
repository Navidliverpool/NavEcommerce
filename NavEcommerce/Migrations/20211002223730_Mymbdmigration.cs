using Microsoft.EntityFrameworkCore.Migrations;

namespace NavEcommerce.Migrations
{
    public partial class Mymbdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandMotorcycle_Brands_BrandId",
                table: "BrandMotorcycle");

            migrationBuilder.DropForeignKey(
                name: "FK_BrandMotorcycle_Motorcycles_MotorcycleId",
                table: "BrandMotorcycle");

            migrationBuilder.DropColumn(
                name: "Dealers",
                table: "BrandMotorcycle");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Motorcycles",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "MotorcycleId",
                table: "BrandMotorcycle",
                newName: "MotorcyclesId");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "BrandMotorcycle",
                newName: "BrandsId");

            migrationBuilder.RenameIndex(
                name: "IX_BrandMotorcycle_MotorcycleId",
                table: "BrandMotorcycle",
                newName: "IX_BrandMotorcycle_MotorcyclesId");

            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Motorcycle = table.Column<bool>(type: "bit", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dealers_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_BrandId",
                table: "Dealers",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandMotorcycle_Brands_BrandsId",
                table: "BrandMotorcycle",
                column: "BrandsId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BrandMotorcycle_Motorcycles_MotorcyclesId",
                table: "BrandMotorcycle",
                column: "MotorcyclesId",
                principalTable: "Motorcycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandMotorcycle_Brands_BrandsId",
                table: "BrandMotorcycle");

            migrationBuilder.DropForeignKey(
                name: "FK_BrandMotorcycle_Motorcycles_MotorcyclesId",
                table: "BrandMotorcycle");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Motorcycles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MotorcyclesId",
                table: "BrandMotorcycle",
                newName: "MotorcycleId");

            migrationBuilder.RenameColumn(
                name: "BrandsId",
                table: "BrandMotorcycle",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_BrandMotorcycle_MotorcyclesId",
                table: "BrandMotorcycle",
                newName: "IX_BrandMotorcycle_MotorcycleId");

            migrationBuilder.AddColumn<string>(
                name: "Dealers",
                table: "BrandMotorcycle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BrandMotorcycle_Brands_BrandId",
                table: "BrandMotorcycle",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BrandMotorcycle_Motorcycles_MotorcycleId",
                table: "BrandMotorcycle",
                column: "MotorcycleId",
                principalTable: "Motorcycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
