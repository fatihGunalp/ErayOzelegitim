using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_CoffeeApplication.Migrations
{
    /// <inheritdoc />
    public partial class addedSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeSize",
                columns: table => new
                {
                    CoffeeId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeSize", x => new { x.SizeId, x.CoffeeId });
                    table.ForeignKey(
                        name: "FK_CoffeeSize_Cofees_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Cofees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoffeeSize_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeSize_CoffeeId",
                table: "CoffeeSize",
                column: "CoffeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoffeeSize");

            migrationBuilder.DropTable(
                name: "Size");
        }
    }
}
