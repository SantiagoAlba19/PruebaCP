using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiMagos.Models
{
    public partial class sql10433703Context : DbContext
    {
        public sql10433703Context()
        {
        }

        public sql10433703Context(DbContextOptions<sql10433703Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Inscripcion> Inscripcions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=InscripcionMagos.mssql.somee.com;Database=InscripcionMagos;User ID=santiagoAlba19_SQLLogin_1;Password=vc4pfkuws1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Inscripcion>(entity =>
            {
                entity.ToTable("Inscripcion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("apellido");

                entity.Property(e => e.Casa)
                    .IsRequired()
                    .HasColumnName("casa");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Identificacion).HasColumnName("identificacion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
