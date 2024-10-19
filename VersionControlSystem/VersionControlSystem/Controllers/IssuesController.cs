using Microsoft.AspNetCore.Mvc;
using VersionControlSystem.Models;
using VersionControlSystem.Models.Data;

namespace VersionControlSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssuesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IssuesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetIssues([FromQuery] string search, [FromQuery] IssueStatus? status)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetIssue(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateIssue([FromBody] Issue issue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateIssue(int id, [FromBody] Issue issue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteIssue(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }
    }
}
