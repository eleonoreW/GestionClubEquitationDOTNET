using System;
using ClubEquitation.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClubEquitation.Models
{
    public partial class BDClubEquitationContext : ClubEquitationContext
    {
        public BDClubEquitationContext(DbContextOptions<ClubEquitationContext> options) : base(options)
        {
        }

        public virtual DbSet<Activite> Activite { get; set; }
        public virtual DbSet<Cheval> Cheval { get; set; }
        public virtual DbSet<ChevalActivite> ChevalActivite { get; set; }
        public virtual DbSet<Lieu> Lieu { get; set; }
        public virtual DbSet<Race> Race { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BDClubEquitation;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Activite>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Commentaire)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LieuId).HasColumnName("LieuID");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfesseurId).HasColumnName("ProfesseurID");

                entity.Property(e => e.SearchString)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Lieu)
                    .WithMany(p => p.Activite)
                    .HasForeignKey(d => d.LieuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Activite_FK_Lieu");

                entity.HasOne(d => d.Professeur)
                    .WithMany(p => p.Activite)
                    .HasForeignKey(d => d.ProfesseurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Activite_FK_Professeur");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Activite)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Activite_FK_Type");
            });

            modelBuilder.Entity<Cheval>(entity =>
            {
                entity.HasIndex(e => e.Nom)
                    .HasName("UQ__Cheval__C7D1C61EF6582795")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Commentaire)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateNaissance).HasColumnType("date");

                entity.Property(e => e.Descriptif)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProprietaireId).HasColumnName("ProprietaireID");

                entity.Property(e => e.RaceId).HasColumnName("RaceID");

                entity.Property(e => e.SearchString)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Proprietaire)
                    .WithMany(p => p.Cheval)
                    .HasForeignKey(d => d.ProprietaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cheval_FK_Proprietaire");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.Cheval)
                    .HasForeignKey(d => d.RaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cheval_FK_Race");
            });

            modelBuilder.Entity<ChevalActivite>(entity =>
            {
                entity.HasKey(e => new { e.ChevalId, e.ActiviteId });

                entity.ToTable("Cheval_Activite");

                entity.Property(e => e.ChevalId).HasColumnName("ChevalID");

                entity.Property(e => e.ActiviteId).HasColumnName("ActiviteID");

                entity.HasOne(d => d.Activite)
                    .WithMany(p => p.ChevalActivite)
                    .HasForeignKey(d => d.ActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChevalActivite_FK_Activite");

                entity.HasOne(d => d.Cheval)
                    .WithMany(p => p.ChevalActivite)
                    .HasForeignKey(d => d.ChevalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChevalActivite_FK_Cheval");
            });

            modelBuilder.Entity<Lieu>(entity =>
            {
                entity.HasIndex(e => e.Nom)
                    .HasName("UQ__Lieu__C7D1C61EE3386B39")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descriptif)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.HasIndex(e => e.Nom)
                    .HasName("UQ__Race__C7D1C61E5906D50C")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiviteId).HasColumnName("ActiviteID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SearchString)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UtilisateurId).HasColumnName("UtilisateurID");

                entity.HasOne(d => d.Activite)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.ActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_FK_Activite");

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.UtilisateurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_FK_Utilisateur");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasIndex(e => e.Nom)
                    .HasName("UQ__Type__C7D1C61E3790728B")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descriptif)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
