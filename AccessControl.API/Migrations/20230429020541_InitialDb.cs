﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccessControl.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mvTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaUso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FueUsada = table.Column<bool>(type: "bit", nullable: false),
                    Porteria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mvTickets", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mvTickets_Id",
                table: "mvTickets",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mvTickets");
        }
    }
}
