using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dernek.Repository.Migrations
{
    public partial class RemovedCarouselImageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Carousels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Carousels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
