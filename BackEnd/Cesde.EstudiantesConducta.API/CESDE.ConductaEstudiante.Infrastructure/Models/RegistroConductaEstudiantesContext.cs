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

        public virtual DbSet<ConductaEstudiante> ConductaEstudiantes { get; set; } = null!;

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
            modelBuilder.Entity<ConductaEstudiante>(entity =>
            {
                entity.ToTable("ConductaEstudiante");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Documento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("documento");

                entity.Property(e => e.FechaNovedad)
                    .HasColumnType("date")
                    .HasColumnName("fecha_novedad");

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasColumnName("observaciones");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primer_apellido");

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primer_nombre");

                entity.Property(e => e.ProgramaAcademico)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("programa_academico");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundo_apellido");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundo_nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
