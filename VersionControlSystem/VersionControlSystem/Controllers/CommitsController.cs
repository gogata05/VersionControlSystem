using Microsoft.AspNetCore.Mvc;
using VersionControlSystem.Models;
using VersionControlSystem.Models.Data;

namespace VersionControlSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommitsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CommitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Commits
        [HttpGet]
        public IActionResult GetCommits([FromQuery] string search, [FromQuery] int? authorId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Логика за получаване на списък с комити
            throw new NotImplementedException();
        }

        // GET: api/Commits/{id}
        [HttpGet("{id}")]
        public IActionResult GetCommit(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Логика за получаване на конкретен комит
            throw new NotImplementedException();
        }

        // POST: api/Commits
        [HttpPost]
        public IActionResult CreateCommit([FromBody] Commit commit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Логика за създаване на комит
            throw new NotImplementedException();
        }
    }
}
