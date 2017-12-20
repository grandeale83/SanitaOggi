using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SanitaOggi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambulatorio",
                columns: table => new
                {
                    AmbulatorioID = table.Column<string>(nullable: false),
                    CodStruttura = table.Column<string>(nullable: false),
                    CodTipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambulatorio", x => x.AmbulatorioID);
                });

            migrationBuilder.CreateTable(
                name: "Struttura",
                columns: table => new
                {
                    StrutturaID = table.Column<string>(nullable: false),
                    AmbulatorioID = table.Column<string>(nullable: true),
                    CodiceStruttura = table.Column<string>(nullable: false),
                    NomeStruttura = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Struttura", x => x.StrutturaID);
                    table.ForeignKey(
                        name: "FK_Struttura_Ambulatorio_AmbulatorioID",
                        column: x => x.AmbulatorioID,
                        principalTable: "Ambulatorio",
                        principalColumn: "AmbulatorioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoAmbulatorio",
                columns: table => new
                {
                    TipoAmbulatorioID = table.Column<string>(nullable: false),
                    AmbulatorioID = table.Column<string>(nullable: true),
                    CodiceTipo = table.Column<string>(nullable: false),
                    NomeTipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAmbulatorio", x => x.TipoAmbulatorioID);
                    table.ForeignKey(
                        name: "FK_TipoAmbulatorio_Ambulatorio_AmbulatorioID",
                        column: x => x.AmbulatorioID,
                        principalTable: "Ambulatorio",
                        principalColumn: "AmbulatorioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Struttura_AmbulatorioID",
                table: "Struttura",
                column: "AmbulatorioID");

            migrationBuilder.CreateIndex(
                name: "IX_TipoAmbulatorio_AmbulatorioID",
                table: "TipoAmbulatorio",
                column: "AmbulatorioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Struttura");

            migrationBuilder.DropTable(
                name: "TipoAmbulatorio");

            migrationBuilder.DropTable(
                name: "Ambulatorio");
        }
    }
}
