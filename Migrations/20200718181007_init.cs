using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameAd = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Mark = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Km = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Describe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
