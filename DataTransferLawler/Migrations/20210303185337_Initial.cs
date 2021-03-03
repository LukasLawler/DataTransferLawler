using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTransferLawler.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CountryFlag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "winter", "Winter Olympics" },
                    { "summer", "Summer Olympics" },
                    { "para", "Paralympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "Name" },
                values: new object[,]
                {
                    { "curl", "Curling/Indoor" },
                    { "bob", "Bobsleigh/Outdoor" },
                    { "dive", "Diving/Indoor" },
                    { "road", "Road Cycling/Outdoor" },
                    { "arch", "Archery/Indoor" },
                    { "canoe", "Canoe Sprint/Outdoor" },
                    { "break", "Breakdancing/Indoor" },
                    { "skate", "Skateboarding/Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryFlag", "GameID", "Name", "SportID" },
                values: new object[,]
                {
                    { "can", "Canada.jpg", "winter", "Canada", "curl" },
                    { "fin", "Finland.jpg", "youth", "Finland", "skate" },
                    { "rus", "Russia.jpg", "youth", "Russia", "break" },
                    { "cyp", "Cyprus.jpg", "youth", "Cyprus", "break" },
                    { "fra", "France.jpg", "youth", "France", "break" },
                    { "zim", "Zimbabwe.jpg", "para", "Zimbabwe", "canoe" },
                    { "pak", "Pakistan.jpg", "para", "Pakistan", "canoe" },
                    { "aus", "Austria.jpg", "para", "Austria", "canoe" },
                    { "ukr", "Ukraine.jpg", "para", "Ukraine", "arch" },
                    { "uru", "Uruguay.jpg", "para", "Uruguay", "arch" },
                    { "tha", "Thailand.jpg", "para", "Thailand", "arch" },
                    { "usa", "USA.jpg", "summer", "USA", "road" },
                    { "net", "Netherlands.jpg", "summer", "Netherlands", "road" },
                    { "bra", "Brazil.jpg", "summer", "Brazil", "road" },
                    { "mex", "Maxico.jpg", "summer", "Mexico", "dive" },
                    { "chi", "China.jpg", "summer", "China", "dive" },
                    { "ger", "Germany.jpg", "summer", "Germany", "dive" },
                    { "jap", "Japan.jpg", "winter", "Japan", "bob" },
                    { "ita", "Italy.jpg", "winter", "Italy", "bob" },
                    { "jam", "Jamaica.jpg", "winter", "Jamaica", "bob" },
                    { "gb", "Britain.jpg", "winter", "Great Britain", "curl" },
                    { "swe", "Sweden.jpg", "winter", "Sweden", "curl" },
                    { "slo", "Slovakia.jpg", "youth", "Slovakia", "skate" },
                    { "por", "Portugal.jpg", "youth", "Portugal", "skate" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
