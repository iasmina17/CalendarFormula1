using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarFormula1.Migrations
{
    /// <inheritdoc />
    public partial class Initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pilotii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumePilot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumarPilot = table.Column<int>(type: "int", nullable: false),
                    Echipa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taraa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeTara = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taraa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursaa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeCursa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCursa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategorieCircuit = table.Column<int>(type: "int", nullable: false),
                    TaraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursaa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursaa_Taraa_TaraId",
                        column: x => x.TaraId,
                        principalTable: "Taraa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pilotii_Cursaa",
                columns: table => new
                {
                    CursaId = table.Column<int>(type: "int", nullable: false),
                    PilotiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotii_Cursaa", x => new { x.PilotiId, x.CursaId });
                    table.ForeignKey(
                        name: "FK_Pilotii_Cursaa_Cursaa_CursaId",
                        column: x => x.CursaId,
                        principalTable: "Cursaa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pilotii_Cursaa_Pilotii_PilotiId",
                        column: x => x.PilotiId,
                        principalTable: "Pilotii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursaa_TaraId",
                table: "Cursaa",
                column: "TaraId");

            migrationBuilder.CreateIndex(
                name: "IX_Pilotii_Cursaa_CursaId",
                table: "Pilotii_Cursaa",
                column: "CursaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pilotii_Cursaa");

            migrationBuilder.DropTable(
                name: "Cursaa");

            migrationBuilder.DropTable(
                name: "Pilotii");

            migrationBuilder.DropTable(
                name: "Taraa");
        }
    }
}
