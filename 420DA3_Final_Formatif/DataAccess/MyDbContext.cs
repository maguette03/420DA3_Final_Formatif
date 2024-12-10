using _420DA3_Final_Formatif.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.DataAccess
{

    //doit heriter de DBcontext de entity FrameWork
    internal class MyDbContext : DbContext
    {



        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = ConfigurationManager.ConnectionStrings["ExamenDatabase"].ConnectionString;

            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuration des entites
            _ = modelBuilder.Entity<Country>()
                .ToTable(nameof(Countries))
                .HasKey(c => c.Id);

            _= modelBuilder.Entity<Language>()
            .ToTable(nameof(Languages))
            .HasKey(l => l.Id);

            //Configurations des colones
            _ = modelBuilder.Entity<Country>()
               .Property(c => c.Id)
               .HasColumnName(nameof(Country.Id))
               .HasColumnOrder(0)
               .HasColumnType("int")
               .UseIdentityColumn(1, 1);

            _ = modelBuilder.Entity<Country>()
                .Property(c => c.ShortName)
                .HasColumnName(nameof(Country.ShortName))
                .HasColumnOrder(1)
                .HasColumnType($"nvarchar({Country.SHORT_NAME_MAX_LENGTH}")
                .IsRequired(true);

            _= modelBuilder.Entity<Country>()
                .Property(c => c.FullName)
                .HasColumnName(nameof(Country.FullName))
                .HasColumnOrder(2)
                .HasColumnType($"nvarchar({Country.FULL_NAME_MAX_LENGTH})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Country>()
                .Property(c => c.RowVersion)
                .HasColumnName(nameof(Country.RowVersion))
                .HasColumnOrder(3)
                .IsRowVersion();


            
            _=modelBuilder.Entity<Language>()
                .Property(l => l.Id)
                .HasColumnName(nameof(Language.Id))
                .HasColumnOrder (0)
                .HasColumnType("int")
                .UseIdentityColumn (1, 1);

            _ = modelBuilder.Entity<Language>()
                .Property(l => l.Name)
                .HasColumnName(nameof(Language.Name))
                .HasColumnOrder(1)
                .HasColumnType($"nvarchar({Language.NAME_MAX_LENGTH})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Language>()
                .Property(l => l.IsoCode)
                .HasColumnName(nameof(Language.IsoCode))
                .HasColumnOrder(2)
                .HasColumnType($"nvarchar({Language.ISOCODE_MAX_LENGTH})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Language>()
                .Property(l => l.RowVersion)
                .HasColumnName(nameof(Language.RowVersion))
                .HasColumnOrder(3)
                .IsRowVersion();



            Language lang1 = new Language { Id = 1, Name = "English", IsoCode = "en" };
            Language lang2 = new Language { Id = 2, Name = "French", IsoCode = "fr" };
            Language lang3 = new Language { Id = 3, Name = "Greman", IsoCode = "de" };

            //configuation des relations et donnes initiales
            _ = modelBuilder.Entity<Language>()
                .HasData(lang1, lang2, lang3);

            Country country1 = new Country { Id = 1, ShortName = "Canada", FullName = "Dominion of Canada" };
            Country country2 = new Country { Id = 2, ShortName = "Germany", FullName = "Federal Republic  of Germany" };

            _= modelBuilder.Entity<Country>()
               .HasData(country1, country2);


            _ = modelBuilder.Entity<Country>()
                .HasMany(c => c.Languages)
                .WithMany(l => l.CountriesSpoken)
                .UsingEntity(
                "CountriesLanguages",
                    leftRel => leftRel.HasOne(typeof(Language)).WithMany().HasForeignKey("LanguageId"),
                    righRel => righRel.HasOne(typeof(Country)).WithMany().HasForeignKey("CountryId"),
                    conf =>
                    {
                        conf.ToTable("CountriesLanguages").HasKey("CountryId", "LanguageId");
                        conf.HasData(
                            new { CountryId = 1, LanguageId = 1 },
                            new { CountryId = 2, LanguageId = 3 }
                        );
                    }
                );

            /*
            URGENT APRES LA CONFIGURATION DES ENTITE  POUR  Utilisez le système de migrations de Entity Framework Core pour faire générer la base de
            données à partir des configurations des entités. IL faut aller DANS Tools puis cliquer sur Nuget Package Manager ensuite  cliquer sur  Package Manager Console  et ecrire ce qui suis pour pouvoi
            gener la base de donnes " Add-Migration InitialCreate"  apres sa on fait la mis a jour avec " Update-Database"*/
        }
    }
}
