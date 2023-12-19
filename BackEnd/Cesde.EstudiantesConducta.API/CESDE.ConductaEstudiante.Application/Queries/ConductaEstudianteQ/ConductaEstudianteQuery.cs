using CESDE.ConductaEstudiante.Application.Dtos.ConductaEstudiante;
using CESDE.ConductaEstudiante.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CESDE.ConductaEstudiante.Application.Queries.ConductaEstudianteQ
{
    public class ConductaEstudianteQuery : IRequest<List<ConductaEstudianteDto>>
    {

    }

    public class ConductaEstudianteQueryHanlder : IRequestHandler<ConductaEstudianteQuery, List<ConductaEstudianteDto>>
    {
        private readonly IApplicationDbcontexts _contexts;
        private readonly ILogger<ConductaEstudianteQueryHanlder> _logger;

        public ConductaEstudianteQueryHanlder(IApplicationDbcontexts contexts, ILogger<ConductaEstudianteQueryHanlder> logger)
        {
            _contexts = contexts;
            _logger = logger;
        }

        public async Task<List<ConductaEstudianteDto>> Handle(ConductaEstudianteQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("ConductaEstudianteQueryHanlder started");

            var estudiantes = await _contexts.Estudiantes.Select(x => new ConductaEstudianteDto()
            {
                IdEstudiante = x.IdEstudiante,
                PrimerNombre = x.PrimerNombre,
                SegundoNombre = x.SegundoNombre,
                PrimerApellido = x.PrimerApellido,
                SegundoApellido = x.SegundoApellido,
                ProgramaAcademico = x.ProgramaAcademico,

            }).ToListAsync(cancellationToken);

            _logger.LogInformation("ConductaEstudianteQueryHanlder finished");
            return estudiantes;
        }
    }
}
