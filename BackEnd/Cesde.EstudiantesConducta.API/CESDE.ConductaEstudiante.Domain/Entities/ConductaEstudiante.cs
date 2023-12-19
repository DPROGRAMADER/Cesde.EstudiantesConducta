namespace CESDE.ConductaEstudiante.Domain.Entities
{
    public class ConductaEstudiantes
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
