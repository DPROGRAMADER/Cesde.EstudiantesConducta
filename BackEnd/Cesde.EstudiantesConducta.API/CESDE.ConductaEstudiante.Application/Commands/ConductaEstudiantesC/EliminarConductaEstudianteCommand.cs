using CESDE.ConductaEstudiante.Application.Interfaces;
using CESDE.ConductaEstudiante.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC
{
    public class EliminarConductaEstudiante : IRequest<bool>
    {
        public int IdEstudiante { get; set; }

    }

    public class EliminarConductaEstudianteHanlder : IRequestHandler<EliminarConductaEstudiante, bool>
    {
        private readonly IApplicationDbcontexts _context;
        private readonly ILogger<EliminarConductaEstudianteHanlder> _logger;


        public EliminarConductaEstudianteHanlder(IApplicationDbcontexts contexts, ILogger<EliminarConductaEstudianteHanlder> logger)
        {
            _context = contexts;
            _logger = logger;
        }

        public async Task<bool> Handle(EliminarConductaEstudiante request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("EliminarConductaEstudianteHanlder started");

            var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(x => x.IdEstudiante == request.IdEstudiante);

            if (estudiante == null)
            {
                _logger.LogInformation(" Conducta no encontrada ");

            }
            _context.Estudiantes.Remove(estudiante);

            await _context.SaveChangesAsync(cancellationToken);

             _logger.LogDebug("EliminarConductaEstudianteHanlder finished");

            return true;
        }
    }
}
