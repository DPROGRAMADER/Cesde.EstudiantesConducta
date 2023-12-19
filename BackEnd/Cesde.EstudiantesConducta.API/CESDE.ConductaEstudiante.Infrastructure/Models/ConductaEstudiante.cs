using System;
using System.Collections.Generic;

namespace CESDE.ConductaEstudiante.Infrastructure.Models
{
    public partial class ConductaEstudiante
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
