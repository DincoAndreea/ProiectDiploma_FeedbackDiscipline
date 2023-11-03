using AWSServerlessFeedbackDiscipline.Modele;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AWSServerlessFeedbackDiscipline.ContextBazaDeDate
{
    public class FeedbackDisciplineContext : IdentityDbContext<IdentityUser>
    {
        public FeedbackDisciplineContext (DbContextOptions<FeedbackDisciplineContext> optiuni) : base(optiuni)
        {

        }

        public DbSet<AniDeStudiu> AniDeStudiu { get; set; }
        public DbSet<Chestionare> Chestionare { get; set; }
        public DbSet<CiclulDeStudii> CiclulDeStudii { get; set; }
        public DbSet<Discipline> Discipline { get; set; }
        public DbSet<ProgrameStudiu> ProgrameDeStudiu { get; set; }
        public DbSet<TipuriActivitati> TipuriActivitati { get; set; }
        public DbSet<TokenReimprospatare> TokenReimprospatare { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().ToTable("Utilizatori");
            builder.Entity<IdentityUser>(p =>
            {
                p.Property(o => o.Id).HasColumnName("id_utilizator");
                p.Property(o => o.UserName).HasColumnName("nume_utilizator");
                p.Property(o => o.NormalizedUserName).HasColumnName("nume_utilizator_majuscule");
                p.Property(o => o.Email).HasColumnName("email");
                p.Property(o => o.NormalizedEmail).HasColumnName("email_majuscule");
                p.Property(o => o.EmailConfirmed).HasColumnName("confirmare_email");
                p.Property(o => o.PasswordHash).HasColumnName("hash_parola");
                p.Property(o => o.SecurityStamp).HasColumnName("stampila_de_securitate");
                p.Property(o => o.ConcurrencyStamp).HasColumnName("stampila_concurenta_date");
                p.Property(o => o.PhoneNumber).HasColumnName("numar_telefon");
                p.Property(o => o.PhoneNumberConfirmed).HasColumnName("confirmare_numar_telefon");
                p.Property(o => o.TwoFactorEnabled).HasColumnName("autentificare_doi_factori");
                p.Property(o => o.LockoutEnd).HasColumnName("data_expirare_utilizator_blocat");
                p.Property(o => o.LockoutEnabled).HasColumnName("blocare_utilizator");
                p.Property(o => o.AccessFailedCount).HasColumnName("numar_accesari_cont_esuate");
            });
            builder.Entity<IdentityRole>().ToTable("Roluri");
            builder.Entity<IdentityRole>(p =>
            {
                p.Property(o => o.Id).HasColumnName("id_rol");
                p.Property(o => o.Name).HasColumnName("nume_rol");
                p.Property(o => o.NormalizedName).HasColumnName("nume_rol_majuscule");
                p.Property(o => o.ConcurrencyStamp).HasColumnName("stampila_concurenta_date");
            });
            builder.Entity<IdentityUserClaim<string>>().ToTable("AtributeUtilizatori");
            builder.Entity<IdentityUserClaim<string>>(p =>
            {
                p.Property(o => o.Id).HasColumnName("id_atribute_utilizator");
                p.Property(o => o.UserId).HasColumnName("id_utilizator");
                p.Property(o => o.ClaimType).HasColumnName("tip_atribut");
                p.Property(o => o.ClaimValue).HasColumnName("valoare_atribut");
            });
            builder.Entity<IdentityUserRole<string>>().ToTable("RoluriUtilizatori");
            builder.Entity<IdentityUserRole<string>>(p =>
            {
                p.Property(o => o.UserId).HasColumnName("id_utilizator");
                p.Property(o => o.RoleId).HasColumnName("id_rol");
            });
            builder.Entity<IdentityUserLogin<string>>().ToTable("LogareUtilizator");
            builder.Entity<IdentityUserLogin<string>>(p =>
            {
                p.Property(o => o.LoginProvider).HasColumnName("furnizor_logare");
                p.Property(o => o.ProviderKey).HasColumnName("cheie_furnizor");
                p.Property(o => o.ProviderDisplayName).HasColumnName("nume_furnizor");
                p.Property(o => o.UserId).HasColumnName("id_utilizator");
            });
            builder.Entity<IdentityRoleClaim<string>>().ToTable("AtributeRoluri");
            builder.Entity<IdentityRoleClaim<string>>(p =>
            {
                p.Property(o => o.Id).HasColumnName("id_atribut_rol");
                p.Property(o => o.RoleId).HasColumnName("id_rol");
                p.Property(o => o.ClaimType).HasColumnName("tip_atribut");
                p.Property(o => o.ClaimValue).HasColumnName("valoare_atribut");
            });
            builder.Entity<IdentityUserToken<string>>().ToTable("TokenUtilizatori");
            builder.Entity<IdentityUserToken<string>>(p =>
            {
                p.Property(o => o.UserId).HasColumnName("id_utilizator");
                p.Property(o => o.LoginProvider).HasColumnName("furnizor_logare");
                p.Property(o => o.Name).HasColumnName("nume");
                p.Property(o => o.Value).HasColumnName("valoare");
            });
        }

    }
}
