using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Paskaita_3_EntityFramework.Migrations.Projektas
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skyriai",
                columns: table => new
                {
                    SkyriusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VadovoAsmensKodas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skyriai", x => x.SkyriusId);
                });

            migrationBuilder.CreateTable(
                name: "Projektai",
                columns: table => new
                {
                    ProjektoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pradzia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trukme = table.Column<int>(type: "int", nullable: false),
                    SkyriusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projektai", x => x.ProjektoId);
                    table.ForeignKey(
                        name: "FK_Projektai_Skyriai_SkyriusId",
                        column: x => x.SkyriusId,
                        principalTable: "Skyriai",
                        principalColumn: "SkyriusId");
                });

            migrationBuilder.CreateTable(
                name: "Darbuotojai",
                columns: table => new
                {
                    DarbuotojasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsmensKodas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vardas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pavarde = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirbaNuo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GimimoMetai = table.Column<int>(type: "int", nullable: false),
                    Pareigos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkyriusId = table.Column<int>(type: "int", nullable: false),
                    ProjektasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Darbuotojai", x => x.DarbuotojasId);
                    table.ForeignKey(
                        name: "FK_Darbuotojai_Projektai_ProjektasId",
                        column: x => x.ProjektasId,
                        principalTable: "Projektai",
                        principalColumn: "ProjektoId");
                    table.ForeignKey(
                        name: "FK_Darbuotojai_Skyriai_SkyriusId",
                        column: x => x.SkyriusId,
                        principalTable: "Skyriai",
                        principalColumn: "SkyriusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Darbuotojai_ProjektasId",
                table: "Darbuotojai",
                column: "ProjektasId");

            migrationBuilder.CreateIndex(
                name: "IX_Darbuotojai_SkyriusId",
                table: "Darbuotojai",
                column: "SkyriusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projektai_SkyriusId",
                table: "Projektai",
                column: "SkyriusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Darbuotojai");

            migrationBuilder.DropTable(
                name: "Projektai");

            migrationBuilder.DropTable(
                name: "Skyriai");
        }
    }
}
