using CESDE.ConductaEstudiante.Application.Interfaces;
using CESDE.ConductaEstudiante.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection;

namespace CESDE.ConductaEstudiante.Infrastructure.Persistence.DbContexts
{
    public partial class RegistroConductaEstudiantesContext : DbContext, IApplicationDbcontexts
    {

        public virtual DbSet<ConductaEstudiantes> ConductaEstudiantes { get; set; }

        public DatabaseFacade DatabaseFacade => throw new NotImplementedException();

        public RegistroConductaEstudiantesContext()
        {
        }

        public RegistroConductaEstudiantesContext(DbContextOptions<RegistroConductaEstudiantesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}