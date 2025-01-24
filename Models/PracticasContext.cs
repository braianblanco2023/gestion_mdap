using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebFinal.Models
{
    public partial class PracticasContext : DbContext
    {
        public PracticasContext()
        {
        }

        public PracticasContext(DbContextOptions<PracticasContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<ModeloPaises> ModelosPaises { get; set; }
        public virtual DbSet<PaisComercializacion> PaisesComercializacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(//removido por seguridad);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__tmp_ms_x__70331812E1BD1776");

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.NombreMarca)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("nombreMarca")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Modelos>(entity =>
            {
                entity.HasKey(e => e.IdModelo)
                    .HasName("PK__tmp_ms_x__13A52CD10885E0A1");

                entity.Property(e => e.IdModelo).HasColumnName("idModelo");

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.NombreModelo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("nombreModelo")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Modelos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modelos_ToMarcas");
            });

            modelBuilder.Entity<ModeloPaises>(entity =>
            {
                entity.ToTable("Modelos_Paises");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdModelo).HasColumnName("idModelo");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.ModelosPaises)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modelos_Paises_ToModelos");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.ModelosPaises)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modelos_Paises_ToPaises");
            });

            modelBuilder.Entity<PaisComercializacion>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK__tmp_ms_x__BD2285E3C5AAB1F4");

                entity.ToTable("PaisesComercializacion");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.NombrePais)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("nombrePais")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
