using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_Heroes.WebAPI.Migrations
{
    public partial class ajusts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Heroes_OwnerIdId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_OwnerIdId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "OwnerIdId",
                table: "Weapons");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_OwnerHeroId",
                table: "Weapons",
                column: "OwnerHeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Heroes_OwnerHeroId",
                table: "Weapons",
                column: "OwnerHeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Heroes_OwnerHeroId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_OwnerHeroId",
                table: "Weapons");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerIdId",
                table: "Weapons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_OwnerIdId",
                table: "Weapons",
                column: "OwnerIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Heroes_OwnerIdId",
                table: "Weapons",
                column: "OwnerIdId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
