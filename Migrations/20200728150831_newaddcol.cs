using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMVC.Migrations
{
    public partial class newaddcol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileUrl",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileUrl",
                table: "Cars");
        }
    }
}
