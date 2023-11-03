using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWSServerlessFeedbackDiscipline.Migratii
{
    /// <inheritdoc />
    public partial class SchimbareNumeTabele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "TokenUtilizatori");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Utilizatori");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "RoluriUtilizatori");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "LogareUtilizator");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roluri");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "RoluriUtilizatori",
                newName: "IX_RoluriUtilizatori_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "LogareUtilizator",
                newName: "IX_LogareUtilizator_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenUtilizatori",
                table: "TokenUtilizatori",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilizatori",
                table: "Utilizatori",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoluriUtilizatori",
                table: "RoluriUtilizatori",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogareUtilizator",
                table: "LogareUtilizator",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roluri",
                table: "Roluri",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Roluri_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Roluri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Utilizatori_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Utilizatori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogareUtilizator_Utilizatori_UserId",
                table: "LogareUtilizator",
                column: "UserId",
                principalTable: "Utilizatori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoluriUtilizatori_Roluri_RoleId",
                table: "RoluriUtilizatori",
                column: "RoleId",
                principalTable: "Roluri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoluriUtilizatori_Utilizatori_UserId",
                table: "RoluriUtilizatori",
                column: "UserId",
                principalTable: "Utilizatori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokenUtilizatori_Utilizatori_UserId",
                table: "TokenUtilizatori",
                column: "UserId",
                principalTable: "Utilizatori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Roluri_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Utilizatori_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_LogareUtilizator_Utilizatori_UserId",
                table: "LogareUtilizator");

            migrationBuilder.DropForeignKey(
                name: "FK_RoluriUtilizatori_Roluri_RoleId",
                table: "RoluriUtilizatori");

            migrationBuilder.DropForeignKey(
                name: "FK_RoluriUtilizatori_Utilizatori_UserId",
                table: "RoluriUtilizatori");

            migrationBuilder.DropForeignKey(
                name: "FK_TokenUtilizatori_Utilizatori_UserId",
                table: "TokenUtilizatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilizatori",
                table: "Utilizatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TokenUtilizatori",
                table: "TokenUtilizatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoluriUtilizatori",
                table: "RoluriUtilizatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roluri",
                table: "Roluri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogareUtilizator",
                table: "LogareUtilizator");

            migrationBuilder.RenameTable(
                name: "Utilizatori",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "TokenUtilizatori",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "RoluriUtilizatori",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Roluri",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "LogareUtilizator",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameIndex(
                name: "IX_RoluriUtilizatori_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_LogareUtilizator_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
