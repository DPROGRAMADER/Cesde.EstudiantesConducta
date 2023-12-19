using CESDE.ConductaEstudiante.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CESDE.ConductaEstudiante.Application.Interfaces
{
    public interface IApplicationDbcontexts
    {
        DbSet<ConductaEstudiantes> ConductaEstudiantes { get; set; } 

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        DatabaseFacade DatabaseFacade { get; }
    }
}
