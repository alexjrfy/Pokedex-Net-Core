using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Type1Id",
                table: "Pokemon",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Type2Id",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Type1Id",
                table: "Pokemon",
                column: "Type1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Type2Id",
                table: "Pokemon",
                column: "Type2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Types_Type1Id",
                table: "Pokemon",
                column: "Type1Id",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Types_Type2Id",
                table: "Pokemon",
                column: "Type2Id",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Types_Type1Id",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Types_Type2Id",
                table: "Pokemon");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_Type1Id",
                table: "Pokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_Type2Id",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Type1Id",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Type2Id",
                table: "Pokemon");
        }
    }
}
