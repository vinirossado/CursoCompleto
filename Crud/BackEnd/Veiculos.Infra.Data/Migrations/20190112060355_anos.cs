using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Veiculos.Infra.Data.Migrations
{
    public partial class anos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnoModelo",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "AnoFabricacao",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AnoModelo",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AnoFabricacao",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
