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

        [HttpGet]
        public IActionResult GetPullRequests()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreatePullRequest([FromBody] PullRequest pullRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpPut("{id}/accept")]
        public IActionResult AcceptPullRequest(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }

        [HttpPut("{id}/reject")]
        public IActionResult RejectPullRequest(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            throw new NotImplementedException();
        }
    }
}