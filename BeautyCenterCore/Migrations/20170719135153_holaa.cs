using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeautyCenterCore.Migrations
{
    public partial class holaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Facturas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "Facturas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "Facturas");

            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Facturas",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
