using CESDE.ConductaEstudiante.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CESDE.ConductaEstudiante.Infrastructure.Persistence.Configurations
{
    public class ConductaEstudianteConfiguration : IEntityTypeConfiguration<Estudiante>
    {
        public void Configure(EntityTypeBuilder<Estudiante> builder)
        {
            builder.ToTable("Estudiante");

            builder.Property(e => e.IdEstudiante).HasColumnName("idEstudiante");

            builder.Property(e => e.Fecha).HasColumnType("date");

            builder.Property(e => e.Novedad)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Observacion).HasColumnType("text");

            builder.Property(e => e.PrimerApellido)
                 .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ProgramaAcademico)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
