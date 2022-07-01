using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FiveIntializedEditSpecandSpecMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecificationMaterialId",
                table: "Specifications");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificationMaterials_SpecificationId",
                table: "SpecificationMaterials",
                column: "SpecificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificationMaterials_Specifications_SpecificationId",
                table: "SpecificationMaterials",
                column: "SpecificationId",
                principalTable: "Specifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecificationMaterials_Specifications_SpecificationId",
                table: "SpecificationMaterials");

            migrationBuilder.DropIndex(
                name: "IX_SpecificationMaterials_SpecificationId",
                table: "SpecificationMaterials");

            migrationBuilder.AddColumn<int>(
                name: "SpecificationMaterialId",
                table: "Specifications",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
