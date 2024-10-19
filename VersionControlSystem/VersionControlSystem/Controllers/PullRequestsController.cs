using Microsoft.AspNetCore.Mvc;
using VersionControlSystem.Models;
using VersionControlSystem.Models.Data;

namespace VersionControlSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PullRequestsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PullRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PullRequests
        [HttpGet]
        public IActionResult GetPullRequests()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Логика за получаване на нерешени pull requests
            throw new NotImplementedException();
        }

        // POST: api/PullRequests
        [HttpPost]
        public IActionResult CreatePullRequest([FromBody] PullRequest pullRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Логика за създаване на pull request
            throw new NotImplementedException();
        }

        // PUT: api/PullRequests/{id}/accept
        [HttpPut("{id}/accept")]
        public IActionResult AcceptPullRequest(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Логика за приемане на pull request
            throw new NotImplementedException();
        }

        // PUT: api/PullRequests/{id}/reject
        [HttpPut("{id}/reject")]
        public IActionResult RejectPullRequest(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Логика за отхвърляне на pull request
            throw new NotImplementedException();
        }
    }
}