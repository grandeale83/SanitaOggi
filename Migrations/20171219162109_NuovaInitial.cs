using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SanitaOggi.Migrations
{
    public partial class NuovaInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Struttura_Ambulatorio_AmbulatorioID",
                table: "Struttura");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoAmbulatorio_Ambulatorio_AmbulatorioID",
                table: "TipoAmbulatorio");

            migrationBuilder.DropIndex(
                name: "IX_TipoAmbulatorio_AmbulatorioID",
                table: "TipoAmbulatorio");

            migrationBuilder.DropIndex(
                name: "IX_Struttura_AmbulatorioID",
                table: "Struttura");

            migrationBuilder.DropColumn(
                name: "AmbulatorioID",
                table: "TipoAmbulatorio");

            migrationBuilder.DropColumn(
                name: "AmbulatorioID",
                table: "Struttura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmbulatorioID",
                table: "TipoAmbulatorio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AmbulatorioID",
                table: "Struttura",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoAmbulatorio_AmbulatorioID",
                table: "TipoAmbulatorio",
                column: "AmbulatorioID");

            migrationBuilder.CreateIndex(
                name: "IX_Struttura_AmbulatorioID",
                table: "Struttura",
                column: "AmbulatorioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Struttura_Ambulatorio_AmbulatorioID",
                table: "Struttura",
                column: "AmbulatorioID",
                principalTable: "Ambulatorio",
                principalColumn: "AmbulatorioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoAmbulatorio_Ambulatorio_AmbulatorioID",
                table: "TipoAmbulatorio",
                column: "AmbulatorioID",
                principalTable: "Ambulatorio",
                principalColumn: "AmbulatorioID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
