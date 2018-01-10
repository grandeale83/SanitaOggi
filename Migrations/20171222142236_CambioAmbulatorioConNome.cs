using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SanitaOggi.Migrations
{
    public partial class CambioAmbulatorioConNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodTipo",
                table: "Ambulatorio",
                newName: "NomeTipo");

            migrationBuilder.RenameColumn(
                name: "CodStruttura",
                table: "Ambulatorio",
                newName: "NomeStruttura");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Ambulatorio",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Ambulatorio");

            migrationBuilder.RenameColumn(
                name: "NomeTipo",
                table: "Ambulatorio",
                newName: "CodTipo");

            migrationBuilder.RenameColumn(
                name: "NomeStruttura",
                table: "Ambulatorio",
                newName: "CodStruttura");
        }
    }
}
