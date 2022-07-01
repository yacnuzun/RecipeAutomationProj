using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddSMTableFourIntialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Specifications");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Specifications",
                newName: "SpecificationMaterialId");

            migrationBuilder.CreateTable(
                name: "SpecificationMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    SpecificationId = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<int>(type: "int", nullable: false),
                    Gauger = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationMaterials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecificationMaterials");

            migrationBuilder.RenameColumn(
                name: "SpecificationMaterialId",
                table: "Specifications",
                newName: "Slug");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Specifications",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
