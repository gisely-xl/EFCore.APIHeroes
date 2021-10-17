using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_Heroes.WebAPI.Migrations
{
    public partial class initial_migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_weapons_Heroes_OwnerIdId",
                table: "weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_weapons",
                table: "weapons");

            migrationBuilder.RenameTable(
                name: "weapons",
                newName: "Weapons");

            migrationBuilder.RenameIndex(
                name: "IX_weapons_OwnerIdId",
                table: "Weapons",
                newName: "IX_Weapons_OwnerIdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Heroes_OwnerIdId",
                table: "Weapons",
                column: "OwnerIdId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Heroes_OwnerIdId",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "weapons");

            migrationBuilder.RenameIndex(
                name: "IX_Weapons_OwnerIdId",
                table: "weapons",
                newName: "IX_weapons_OwnerIdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weapons",
                table: "weapons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_weapons_Heroes_OwnerIdId",
                table: "weapons",
                column: "OwnerIdId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
