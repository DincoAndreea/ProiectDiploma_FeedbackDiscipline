using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWSServerlessFeedbackDiscipline.Migratii
{
    /// <inheritdoc />
    public partial class SchimbareNumeColoane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributeRoluri_Roluri_RoleId",
                table: "AtributeRoluri");

            migrationBuilder.DropForeignKey(
                name: "FK_AtributeUtilizatori_Utilizatori_UserId",
                table: "AtributeUtilizatori");

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

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Utilizatori",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Utilizatori",
                newName: "nume_utilizator");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Utilizatori",
                newName: "autentificare_doi_factori");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "Utilizatori",
                newName: "stampila_de_securitate");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "Utilizatori",
                newName: "confirmare_numar_telefon");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Utilizatori",
                newName: "numar_telefon");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Utilizatori",
                newName: "hash_parola");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "Utilizatori",
                newName: "nume_utilizator_majuscule");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "Utilizatori",
                newName: "email_majuscule");

            migrationBuilder.RenameColumn(
                name: "LockoutEnd",
                table: "Utilizatori",
                newName: "data_expirare_utilizator_blocat");

            migrationBuilder.RenameColumn(
                name: "LockoutEnabled",
                table: "Utilizatori",
                newName: "blocare_utilizator");

            migrationBuilder.RenameColumn(
                name: "EmailConfirmed",
                table: "Utilizatori",
                newName: "confirmare_email");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "Utilizatori",
                newName: "stampila_concurenta_date");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "Utilizatori",
                newName: "numar_accesari_cont_esuate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Utilizatori",
                newName: "id_utilizator");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "TokenUtilizatori",
                newName: "valoare");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TokenUtilizatori",
                newName: "nume");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "TokenUtilizatori",
                newName: "furnizor_logare");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TokenUtilizatori",
                newName: "id_utilizator");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "RoluriUtilizatori",
                newName: "id_rol");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RoluriUtilizatori",
                newName: "id_utilizator");

            migrationBuilder.RenameIndex(
                name: "IX_RoluriUtilizatori_RoleId",
                table: "RoluriUtilizatori",
                newName: "IX_RoluriUtilizatori_id_rol");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "Roluri",
                newName: "nume_rol_majuscule");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roluri",
                newName: "nume_rol");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "Roluri",
                newName: "stampila_concurenta_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roluri",
                newName: "id_rol");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "LogareUtilizator",
                newName: "id_utilizator");

            migrationBuilder.RenameColumn(
                name: "ProviderDisplayName",
                table: "LogareUtilizator",
                newName: "nume_furnizor");

            migrationBuilder.RenameColumn(
                name: "ProviderKey",
                table: "LogareUtilizator",
                newName: "cheie_furnizor");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "LogareUtilizator",
                newName: "furnizor_logare");

            migrationBuilder.RenameIndex(
                name: "IX_LogareUtilizator_UserId",
                table: "LogareUtilizator",
                newName: "IX_LogareUtilizator_id_utilizator");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AtributeUtilizatori",
                newName: "id_utilizator");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "AtributeUtilizatori",
                newName: "valoare_atribut");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "AtributeUtilizatori",
                newName: "tip_atribut");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AtributeUtilizatori",
                newName: "id_atribute_utilizator");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeUtilizatori_UserId",
                table: "AtributeUtilizatori",
                newName: "IX_AtributeUtilizatori_id_utilizator");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "AtributeRoluri",
                newName: "id_rol");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "AtributeRoluri",
                newName: "valoare_atribut");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "AtributeRoluri",
                newName: "tip_atribut");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AtributeRoluri",
                newName: "id_atribut_rol");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeRoluri_RoleId",
                table: "AtributeRoluri",
                newName: "IX_AtributeRoluri_id_rol");

            migrationBuilder.AddForeignKey(
                name: "FK_AtributeRoluri_Roluri_id_rol",
                table: "AtributeRoluri",
                column: "id_rol",
                principalTable: "Roluri",
                principalColumn: "id_rol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtributeUtilizatori_Utilizatori_id_utilizator",
                table: "AtributeUtilizatori",
                column: "id_utilizator",
                principalTable: "Utilizatori",
                principalColumn: "id_utilizator",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogareUtilizator_Utilizatori_id_utilizator",
                table: "LogareUtilizator",
                column: "id_utilizator",
                principalTable: "Utilizatori",
                principalColumn: "id_utilizator",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoluriUtilizatori_Roluri_id_rol",
                table: "RoluriUtilizatori",
                column: "id_rol",
                principalTable: "Roluri",
                principalColumn: "id_rol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoluriUtilizatori_Utilizatori_id_utilizator",
                table: "RoluriUtilizatori",
                column: "id_utilizator",
                principalTable: "Utilizatori",
                principalColumn: "id_utilizator",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokenUtilizatori_Utilizatori_id_utilizator",
                table: "TokenUtilizatori",
                column: "id_utilizator",
                principalTable: "Utilizatori",
                principalColumn: "id_utilizator",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributeRoluri_Roluri_id_rol",
                table: "AtributeRoluri");

            migrationBuilder.DropForeignKey(
                name: "FK_AtributeUtilizatori_Utilizatori_id_utilizator",
                table: "AtributeUtilizatori");

            migrationBuilder.DropForeignKey(
                name: "FK_LogareUtilizator_Utilizatori_id_utilizator",
                table: "LogareUtilizator");

            migrationBuilder.DropForeignKey(
                name: "FK_RoluriUtilizatori_Roluri_id_rol",
                table: "RoluriUtilizatori");

            migrationBuilder.DropForeignKey(
                name: "FK_RoluriUtilizatori_Utilizatori_id_utilizator",
                table: "RoluriUtilizatori");

            migrationBuilder.DropForeignKey(
                name: "FK_TokenUtilizatori_Utilizatori_id_utilizator",
                table: "TokenUtilizatori");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Utilizatori",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "stampila_de_securitate",
                table: "Utilizatori",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "stampila_concurenta_date",
                table: "Utilizatori",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "nume_utilizator_majuscule",
                table: "Utilizatori",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "nume_utilizator",
                table: "Utilizatori",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "numar_telefon",
                table: "Utilizatori",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "numar_accesari_cont_esuate",
                table: "Utilizatori",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "hash_parola",
                table: "Utilizatori",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "email_majuscule",
                table: "Utilizatori",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "data_expirare_utilizator_blocat",
                table: "Utilizatori",
                newName: "LockoutEnd");

            migrationBuilder.RenameColumn(
                name: "confirmare_numar_telefon",
                table: "Utilizatori",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "confirmare_email",
                table: "Utilizatori",
                newName: "EmailConfirmed");

            migrationBuilder.RenameColumn(
                name: "blocare_utilizator",
                table: "Utilizatori",
                newName: "LockoutEnabled");

            migrationBuilder.RenameColumn(
                name: "autentificare_doi_factori",
                table: "Utilizatori",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "id_utilizator",
                table: "Utilizatori",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valoare",
                table: "TokenUtilizatori",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "nume",
                table: "TokenUtilizatori",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "furnizor_logare",
                table: "TokenUtilizatori",
                newName: "LoginProvider");

            migrationBuilder.RenameColumn(
                name: "id_utilizator",
                table: "TokenUtilizatori",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "id_rol",
                table: "RoluriUtilizatori",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "id_utilizator",
                table: "RoluriUtilizatori",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoluriUtilizatori_id_rol",
                table: "RoluriUtilizatori",
                newName: "IX_RoluriUtilizatori_RoleId");

            migrationBuilder.RenameColumn(
                name: "stampila_concurenta_date",
                table: "Roluri",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "nume_rol_majuscule",
                table: "Roluri",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "nume_rol",
                table: "Roluri",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id_rol",
                table: "Roluri",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nume_furnizor",
                table: "LogareUtilizator",
                newName: "ProviderDisplayName");

            migrationBuilder.RenameColumn(
                name: "id_utilizator",
                table: "LogareUtilizator",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "cheie_furnizor",
                table: "LogareUtilizator",
                newName: "ProviderKey");

            migrationBuilder.RenameColumn(
                name: "furnizor_logare",
                table: "LogareUtilizator",
                newName: "LoginProvider");

            migrationBuilder.RenameIndex(
                name: "IX_LogareUtilizator_id_utilizator",
                table: "LogareUtilizator",
                newName: "IX_LogareUtilizator_UserId");

            migrationBuilder.RenameColumn(
                name: "valoare_atribut",
                table: "AtributeUtilizatori",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "tip_atribut",
                table: "AtributeUtilizatori",
                newName: "ClaimType");

            migrationBuilder.RenameColumn(
                name: "id_utilizator",
                table: "AtributeUtilizatori",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "id_atribute_utilizator",
                table: "AtributeUtilizatori",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeUtilizatori_id_utilizator",
                table: "AtributeUtilizatori",
                newName: "IX_AtributeUtilizatori_UserId");

            migrationBuilder.RenameColumn(
                name: "valoare_atribut",
                table: "AtributeRoluri",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "tip_atribut",
                table: "AtributeRoluri",
                newName: "ClaimType");

            migrationBuilder.RenameColumn(
                name: "id_rol",
                table: "AtributeRoluri",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "id_atribut_rol",
                table: "AtributeRoluri",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_AtributeRoluri_id_rol",
                table: "AtributeRoluri",
                newName: "IX_AtributeRoluri_RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtributeRoluri_Roluri_RoleId",
                table: "AtributeRoluri",
                column: "RoleId",
                principalTable: "Roluri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtributeUtilizatori_Utilizatori_UserId",
                table: "AtributeUtilizatori",
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
    }
}
