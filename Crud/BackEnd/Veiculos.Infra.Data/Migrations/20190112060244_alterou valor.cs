using Microsoft.EntityFrameworkCore.Migrations;

namespace Veiculos.Infra.Data.Migrations
{
    public partial class alterouvalor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
