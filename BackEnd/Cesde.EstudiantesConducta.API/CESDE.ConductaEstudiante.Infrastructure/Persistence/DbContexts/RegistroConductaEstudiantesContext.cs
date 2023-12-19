using CESDE.ConductaEstudiante.Application.Interfaces;
using CESDE.ConductaEstudiante.Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data.Entity;

namespace CESDE.ConductaEstudiante.Infrastructure.Persistence.DbContexts
{
    public partial class RegistroConductaEstudiantesContext : DbContext, IApplicationDbcontexts
    {
        public virtual DbSet<Estudiante>? Estudiantes { get; set; }

        public DatabaseFacade DatabaseFacade => throw new NotImplementedException();

        Microsoft.EntityFrameworkCore.DbSet<Estudiante> IApplicationDbcontexts.Estudiantes 
        { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}