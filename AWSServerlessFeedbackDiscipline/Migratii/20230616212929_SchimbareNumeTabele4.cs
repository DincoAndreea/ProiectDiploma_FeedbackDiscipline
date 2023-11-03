using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWSServerlessFeedbackDiscipline.Migratii
{
    /// <inheritdoc />
    public partial class SchimbareNumeTabele4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Utilizatori_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AtributeUtilizatori");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AtributeUtilizatori",
                newName: "IX_AtributeUtilizatori_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtributeUtilizatori",
                table: "AtributeUtilizatori",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AtributeUtilizatori_Utilizatori_UserId",
                table: "AtributeUtilizatori",
                column: "UserId",
                principalTable: "Utilizatori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributeUtilizatori_Utilizatori_UserId",
                table: "AtributeUtilizatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtributeUtilizatori",
                table: "AtributeUtilizatori");

            migrationBuilder.RenameTable(
                name: "AtributeUtilizatori",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeUtilizatori_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Utilizatori_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Utilizatori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
