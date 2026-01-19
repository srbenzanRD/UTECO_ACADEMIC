using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Persona 
        { 
            Id = 1, 
            Nombre = "Juan" 
        };
        //p1.Nombre (Juan)
    }
}

class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}
class Empleado
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Salario { get; set; }

    public int PersonaId { get; set; }
    [ForeignKey("PersonaId")]
    public Persona Persona { get; set; }

    public Empleado CrearEmpleado(string nombre, decimal salario)
    {
        this.Persona = new Persona { Nombre = nombre };
        this.Salario = salario;
        return this;
    }
}