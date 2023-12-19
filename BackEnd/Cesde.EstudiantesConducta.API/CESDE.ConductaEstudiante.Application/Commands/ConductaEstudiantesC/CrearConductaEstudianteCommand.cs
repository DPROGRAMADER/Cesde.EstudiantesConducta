using AutoMapper;
using CESDE.ConductaEstudiante.Application.Dtos.ConductaEstudiante;
using CESDE.ConductaEstudiante.Application.Interfaces;
using CESDE.ConductaEstudiante.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC
{
    public class CrearConductaEstudianteCommand : IRequest<ConductaEstudianteDto>
    {
        public string PrimerNombre { get; set; } = null!;
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public string ProgramaAcademico { get; set; } = null!;
        public string? Novedad { get; set; }
        public string? Observacion { get; set; }
        public DateTime? Fecha { get; set; }
        public int IdEstudiante { get; set; }

    }

    public class CrearConductaEstudianteCommandHanlder : IRequestHandler<CrearConductaEstudianteCommand, ConductaEstudianteDto>
    {
        private readonly IApplicationDbcontexts _context;
        private readonly ILogger<CrearConductaEstudianteCommandHanlder> _logger;
        private readonly IMapper _mapper;

        public CrearConductaEstudianteCommandHanlder(IApplicationDbcontexts context, ILogger<CrearConductaEstudianteCommandHanlder> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ConductaEstudianteDto> Handle(CrearConductaEstudianteCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("CrearConductaEstudianteCommandHanlder started");

            var estudiante = _mapper.Map<Estudiante>(request);

            await _context.Estudiantes.AddAsync(estudiante);
            await _context.SaveChangesAsync(cancellationToken);

            _logger.LogDebug("CrearConductaEstudianteCommandHanlder finished");

            return _mapper.Map<ConductaEstudianteDto>(estudiante);

        }
    }
}
