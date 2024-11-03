using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;
using WebApiPerson.context;
namespace WebApiPerson.Controllers
{
    [Route("api/estudiantes")]
    [ApiController]
    public class EstudianteController :ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public EstudianteController(AppDBContext context)

        {
            _dbContext = context;
            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetEstudiante()
        {
            return await _dbContext.Estudiantes.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Estudiante>> PostEstudiante(Estudiante estudiante)
        {
            _dbContext.Estudiantes.Add(estudiante);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction("GetEstudiante",new {id=estudiante.Id},estudiante);

        }

    }
}
