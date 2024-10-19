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

        [HttpGet]
        public IActionResult GetCommits([FromQuery] string search, [FromQuery] int? authorId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetCommit(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateCommit([FromBody] Commit commit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }
    }
}
