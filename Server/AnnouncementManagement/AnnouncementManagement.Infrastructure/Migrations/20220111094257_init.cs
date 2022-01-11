using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnouncementManagement.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cm3 = table.Column<int>(type: "int", nullable: false),
                    Gearbox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speeds = table.Column<int>(type: "int", nullable: false),
                    Cylinders = table.Column<int>(type: "int", nullable: false),
                    Traction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberDoors = table.Column<int>(type: "int", nullable: false),
                    NumberSeats = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    AnnouncementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motorcycles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Cm3 = table.Column<int>(type: "int", nullable: false),
                    Gearbox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motorcycles_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trailers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumberDoors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trailers_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cm3 = table.Column<int>(type: "int", nullable: false),
                    Gearbox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speeds = table.Column<int>(type: "int", nullable: false),
                    Cylinders = table.Column<int>(type: "int", nullable: false),
                    Traction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberDoors = table.Column<int>(type: "int", nullable: false),
                    NumberSeats = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    AnnouncementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trucks_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Cm3 = table.Column<int>(type: "int", nullable: false),
                    Gearbox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speeds = table.Column<int>(type: "int", nullable: false),
                    Cylinders = table.Column<int>(type: "int", nullable: false),
                    Traction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberDoors = table.Column<int>(type: "int", nullable: false),
                    NumberSeats = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    AnnouncementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vans_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_SellerId",
                table: "Announcements",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AnnouncementId",
                table: "Cars",
                column: "AnnouncementId",
                unique: true,
                filter: "[AnnouncementId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_AnnouncementId",
                table: "Motorcycles",
                column: "AnnouncementId",
                unique: true,
                filter: "[AnnouncementId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_AnnouncementId",
                table: "Trailers",
                column: "AnnouncementId",
                unique: true,
                filter: "[AnnouncementId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_AnnouncementId",
                table: "Trucks",
                column: "AnnouncementId",
                unique: true,
                filter: "[AnnouncementId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vans_AnnouncementId",
                table: "Vans",
                column: "AnnouncementId",
                unique: true,
                filter: "[AnnouncementId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Motorcycles");

            migrationBuilder.DropTable(
                name: "Trailers");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "Vans");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
