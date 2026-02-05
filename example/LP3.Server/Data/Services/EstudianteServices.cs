using System.Collections.Generic;
using System.Threading.Tasks;
using LP3.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LP3.Server.Data.Services
{
    public class EstudianteServices(ApplicationDbContext _context)
    {
        // Aquí iniciaremos la implementación del Patrón Repository
        public async Task<List<Estudiante>> GetEstudiantesAsync()
        {
            return await _context.Estudiantes.ToListAsync();
        }
    }
}