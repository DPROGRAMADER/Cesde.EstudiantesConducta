using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CESDE.ConductaEstudiante.Infrastructure.Models
{
    public partial class RegistroConductaEstudiantesContext : DbContext
    {
        public RegistroConductaEstudiantesContext()
        {
        }

        public RegistroConductaEstudiantesContext(DbContextOptions<RegistroConductaEstudiantesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-ST0LLHE2\\SQLEXPRESS;Database=RegistroConductaEstudiantes;Integrated Security=True;TrustServerCertificate=true; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.IdEstudiante)
                    .HasName("PK__Estudian__AEFFDBC52C0D41B6");

                entity.ToTable("Estudiante");

                entity.Property(e => e.IdEstudiante).HasColumnName("idEstudiante");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Novedad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion).HasColumnType("text");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramaAcademico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
