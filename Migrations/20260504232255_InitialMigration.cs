using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValeAtivos324261675.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaracteristicasEquipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Localizacao = table.Column<string>(type: "TEXT", nullable: false),
                    CapacidadeProcessamento = table.Column<double>(type: "REAL", nullable: false),
                    DataUltimaManutencao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmOperacao = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicasEquipamentos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaracteristicasEquipamentos");
        }
    }
}
