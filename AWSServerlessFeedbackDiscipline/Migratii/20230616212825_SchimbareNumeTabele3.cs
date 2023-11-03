using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWSServerlessFeedbackDiscipline.Migratii
{
    /// <inheritdoc />
    public partial class SchimbareNumeTabele3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributeUtilizatori_Roluri_RoleId",
                table: "AtributeUtilizatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtributeUtilizatori",
                table: "AtributeUtilizatori");

            migrationBuilder.RenameTable(
                name: "AtributeUtilizatori",
                newName: "AtributeRoluri");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeUtilizatori_RoleId",
                table: "AtributeRoluri",
                newName: "IX_AtributeRoluri_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtributeRoluri",
                table: "AtributeRoluri",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AtributeRoluri_Roluri_RoleId",
                table: "AtributeRoluri",
                column: "RoleId",
                principalTable: "Roluri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributeRoluri_Roluri_RoleId",
                table: "AtributeRoluri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtributeRoluri",
                table: "AtributeRoluri");

            migrationBuilder.RenameTable(
                name: "AtributeRoluri",
                newName: "AtributeUtilizatori");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeRoluri_RoleId",
                table: "AtributeUtilizatori",
                newName: "IX_AtributeUtilizatori_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtributeUtilizatori",
                table: "AtributeUtilizatori",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AtributeUtilizatori_Roluri_RoleId",
                table: "AtributeUtilizatori",
                column: "RoleId",
                principalTable: "Roluri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
