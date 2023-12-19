using AutoMapper;
using CESDE.ConductaEstudiante.Application.Dtos.ConductaEstudiante;
using CESDE.ConductaEstudiante.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC
{
    public class EditarConductaEstudianteCommand : IRequest<ConductaEstudianteDto>
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

    public class EditarConductaEstudianteCommandHanlder : IRequestHandler<CrearConductaEstudianteCommand, ConductaEstudianteDto>
    {
        private readonly IApplicationDbcontexts _context;
        private readonly ILogger<EditarConductaEstudianteCommandHanlder> _logger;
        private readonly IMapper _mapper;

        public async Task<ConductaEstudianteDto> Handle(CrearConductaEstudianteCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("EditarConductaEstudianteCommandHanlder started");

            var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(x => x.IdEstudiante == request.IdEstudiante, cancellationToken);
            {
                _mapper.Map(request, estudiante);
            }
            
            await _context.SaveChangesAsync(cancellationToken);

            var resultado = _mapper.Map<ConductaEstudianteDto>(estudiante);

            _logger.LogDebug("EditarConductaEstudianteCommandHanlder finished");

            return resultado;

        }
    }
}
