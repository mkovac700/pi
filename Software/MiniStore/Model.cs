using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MiniStore
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Database")
        {
        }

        public virtual DbSet<Artikl> Artikls { get; set; }
        public virtual DbSet<ArtiklNarudzbenica> ArtiklNarudzbenicas { get; set; }
        public virtual DbSet<ArtiklPovratnica> ArtiklPovratnicas { get; set; }
        public virtual DbSet<ArtiklPrimka> ArtiklPrimkas { get; set; }
        public virtual DbSet<ArtiklSkladiste> ArtiklSkladistes { get; set; }
        public virtual DbSet<Dobavljac> Dobavljacs { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Inventura> Inventuras { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Lokacija> Lokacijas { get; set; }
        public virtual DbSet<Narudzbenica> Narudzbenicas { get; set; }
        public virtual DbSet<Povratnica> Povratnicas { get; set; }
        public virtual DbSet<Primka> Primkas { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<RacunArtikl> RacunArtikls { get; set; }
        public virtual DbSet<Satnica> Satnicas { get; set; }
        public virtual DbSet<Skladiste> Skladistes { get; set; }
        public virtual DbSet<Trgovina> Trgovinas { get; set; }
        public virtual DbSet<VrstaKorisnika> VrstaKorisnikas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikl>()
                .HasMany(e => e.ArtiklNarudzbenicas)
                .WithRequired(e => e.Artikl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artikl>()
                .HasMany(e => e.ArtiklPovratnicas)
                .WithRequired(e => e.Artikl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artikl>()
                .HasMany(e => e.ArtiklPrimkas)
                .WithRequired(e => e.Artikl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artikl>()
                .HasMany(e => e.ArtiklSkladistes)
                .WithRequired(e => e.Artikl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artikl>()
                .HasMany(e => e.RacunArtikls)
                .WithRequired(e => e.Artikl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ArtiklPovratnica>()
                .Property(e => e.cijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ArtiklPrimka>()
                .Property(e => e.cijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventura>()
                .Property(e => e.primkaCijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventura>()
                .Property(e => e.povratnicaCijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventura>()
                .Property(e => e.racunCijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventura>()
                .Property(e => e.skladisteCijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Trgovinas)
                .WithMany(e => e.Korisniks)
                .Map(m => m.ToTable("KorisnikTrgovina").MapLeftKey("korisnikId").MapRightKey("trgovinaId"));

            modelBuilder.Entity<Narudzbenica>()
                .HasMany(e => e.ArtiklNarudzbenicas)
                .WithRequired(e => e.Narudzbenica)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Primka>()
                .HasMany(e => e.ArtiklPrimkas)
                .WithRequired(e => e.Primka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Racun>()
                .Property(e => e.iznos)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Racun>()
                .HasMany(e => e.RacunArtikls)
                .WithRequired(e => e.Racun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RacunArtikl>()
                .Property(e => e.cijena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Skladiste>()
                .HasMany(e => e.ArtiklSkladistes)
                .WithRequired(e => e.Skladiste)
                .HasForeignKey(e => e.skaldisteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trgovina>()
                .HasMany(e => e.Povratnicas)
                .WithOptional(e => e.Trgovina)
                .HasForeignKey(e => e.trgovinaId);

            modelBuilder.Entity<Trgovina>()
                .HasMany(e => e.Povratnicas1)
                .WithOptional(e => e.Trgovina1)
                .HasForeignKey(e => e.trgovinaId);

            modelBuilder.Entity<VrstaKorisnika>()
                .HasMany(e => e.Korisniks)
                .WithOptional(e => e.VrstaKorisnika1)
                .HasForeignKey(e => e.vrstaKorisnika);
        }
    }
}
