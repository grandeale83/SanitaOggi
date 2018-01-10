using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SanitaOggi.Migrations
{
    public partial class AddRiferimentiInAmbulatoion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StrutturaID",
                table: "Ambulatorio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StrutturaID1",
                table: "Ambulatorio",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoAmbulatorioID",
                table: "Ambulatorio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TipoAmbulatorioID1",
                table: "Ambulatorio",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ambulatorio_StrutturaID1",
                table: "Ambulatorio",
                column: "StrutturaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Ambulatorio_TipoAmbulatorioID1",
                table: "Ambulatorio",
                column: "TipoAmbulatorioID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ambulatorio_Struttura_StrutturaID1",
                table: "Ambulatorio",
                column: "StrutturaID1",
                principalTable: "Struttura",
                principalColumn: "StrutturaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ambulatorio_TipoAmbulatorio_TipoAmbulatorioID1",
                table: "Ambulatorio",
                column: "TipoAmbulatorioID1",
                principalTable: "TipoAmbulatorio",
                principalColumn: "TipoAmbulatorioID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ambulatorio_Struttura_StrutturaID1",
                table: "Ambulatorio");

            migrationBuilder.DropForeignKey(
                name: "FK_Ambulatorio_TipoAmbulatorio_TipoAmbulatorioID1",
                table: "Ambulatorio");

            migrationBuilder.DropIndex(
                name: "IX_Ambulatorio_StrutturaID1",
                table: "Ambulatorio");

            migrationBuilder.DropIndex(
                name: "IX_Ambulatorio_TipoAmbulatorioID1",
                table: "Ambulatorio");

            migrationBuilder.DropColumn(
                name: "StrutturaID",
                table: "Ambulatorio");

            migrationBuilder.DropColumn(
                name: "StrutturaID1",
                table: "Ambulatorio");

            migrationBuilder.DropColumn(
                name: "TipoAmbulatorioID",
                table: "Ambulatorio");

            migrationBuilder.DropColumn(
                name: "TipoAmbulatorioID1",
                table: "Ambulatorio");
        }
    }
}
