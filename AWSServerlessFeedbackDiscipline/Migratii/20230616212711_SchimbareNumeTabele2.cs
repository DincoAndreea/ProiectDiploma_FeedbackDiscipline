using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWSServerlessFeedbackDiscipline.Migratii
{
    /// <inheritdoc />
    public partial class SchimbareNumeTabele2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Roluri_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AtributeUtilizatori");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributeUtilizatori_Roluri_RoleId",
                table: "AtributeUtilizatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtributeUtilizatori",
                table: "AtributeUtilizatori");

            migrationBuilder.RenameTable(
                name: "AtributeUtilizatori",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeUtilizatori_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Roluri_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Roluri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
