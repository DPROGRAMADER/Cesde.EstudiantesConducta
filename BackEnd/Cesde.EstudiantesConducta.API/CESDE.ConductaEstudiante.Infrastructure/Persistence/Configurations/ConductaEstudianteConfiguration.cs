using CESDE.ConductaEstudiante.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CESDE.ConductaEstudiante.Infrastructure.Persistence.Configurations
{
    public class ConductaEstudianteConfiguration : IEntityTypeConfiguration<ConductaEstudiantes>
    {
        public void Configure(EntityTypeBuilder<ConductaEstudiantes> builder)
        {
            builder.ToTable("ConductaEstudiante");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Documento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("documento");

            builder.Property(e => e.FechaNovedad)
                .HasColumnType("date")
                .HasColumnName("fecha_novedad");

            builder.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");

            builder.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_apellido");

            builder.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_nombre");

            builder.Property(e => e.ProgramaAcademico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("programa_academico");

            builder.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_apellido");

            builder.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_nombre");
        }
     }
 }

