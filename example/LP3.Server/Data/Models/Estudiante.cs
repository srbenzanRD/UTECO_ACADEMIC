using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LP3.Server.Data.Models;

[Table("Estudiantes")]
public class Estudiante
{
    [Key]
    public int Id { get; set; }

    public string Matricula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime? FechaDeNacimiento { get; set; }
}