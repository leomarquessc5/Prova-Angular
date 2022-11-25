﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class add_more_fields_on_jogo_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "SelecaoBId",
                table: "Jogos",
                newName: "selecaoBid");

            migrationBuilder.RenameColumn(
                name: "SelecaoAId",
                table: "Jogos",
                newName: "selecaoAId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoBId",
                table: "Jogos",
                newName: "IX_Jogos_selecaoBid");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoAId",
                table: "Jogos",
                newName: "IX_Jogos_selecaoAId");

            migrationBuilder.AlterColumn<int>(
                name: "selecaoBid",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "selecaoAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_selecaoAId",
                table: "Jogos",
                column: "selecaoAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_selecaoBid",
                table: "Jogos",
                column: "selecaoBid",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_selecaoAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_selecaoBid",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "selecaoBid",
                table: "Jogos",
                newName: "SelecaoBId");

            migrationBuilder.RenameColumn(
                name: "selecaoAId",
                table: "Jogos",
                newName: "SelecaoAId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_selecaoBid",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoBId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_selecaoAId",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoAId");

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoBId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos",
                column: "SelecaoAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos",
                column: "SelecaoBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
