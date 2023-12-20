using AutoMapper;
using CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC;
using CESDE.ConductaEstudiante.Application.Dtos.ConductaEstudiante;
using CESDE.ConductaEstudiante.Application.Interfaces;
using CESDE.ConductaEstudiante.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC
{
    public class EditarConductaEstudianteCommand : IRequest<ConductaEstudianteDto>
    {
        public int Id { get; set; }
        public string Documento { get; set; } = null!;
        public string PrimerNombre { get; set; } = null!;
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public string ProgramaAcademico { get; set; } = null!;
        public DateTime FechaNovedad { get; set; }
        public string? Observaciones { get; set; }
    }

}

    public class EditarConductaEstudianteCommandHanlder : IRequestHandler<EditarConductaEstudianteCommand, ConductaEstudianteDto>
    {
        private readonly IApplicationDbcontexts _context;
        private readonly ILogger<EditarConductaEstudianteCommandHanlder> _logger;
        private readonly IMapper _mapper;


    public EditarConductaEstudianteCommandHanlder(IApplicationDbcontexts  context, ILogger<EditarConductaEstudianteCommandHanlder> logger, IMapper mapper)
    {
        _context = context;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<ConductaEstudianteDto> Handle(EditarConductaEstudianteCommand request, CancellationToken cancellationToken)
        {
            _logger.LogDebug("EditarConductaEstudianteCommandHanlder started");

            var conductaEstudiante = await _context.ConductaEstudiantes.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            {
                _mapper.Map(request, conductaEstudiante);
            }
            
            await _context.SaveChangesAsync(cancellationToken);

            var resultado = _mapper.Map<ConductaEstudianteDto>(conductaEstudiante);

            _logger.LogDebug("EditarConductaEstudianteCommandHanlder finished");

            return resultado;

        }  
}

