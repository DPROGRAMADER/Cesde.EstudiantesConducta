namespace CESDE.ConductaEstudiante.Domain.Entities
{
    public class Estudiante
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
}

