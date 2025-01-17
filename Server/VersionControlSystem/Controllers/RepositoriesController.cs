﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VersionControlSystem.Models;
using VersionControlSystem.Models.Data;
using VersionControlSystem.Models.Dtos;

namespace VersionControlSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepositoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RepositoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetRepositories([FromQuery] string? search)
        {
            int currentUserId = 1;

            var repositories = _context.Repositories
                .Include(r => r.Contributors)
                .Where(r => r.IsPublic || r.OwnerId == currentUserId || r.Contributors.Any(c => c.UserId == currentUserId));

            if (!string.IsNullOrEmpty(search))
            {
                repositories = repositories.Where(r => r.Title.Contains(search));
            }

            var result = repositories
                .OrderByDescending(r => r.Id)
                .Select(r => new
                {
                    r.Id,
                    r.Title,
                    r.IsPublic
                })
                .ToList();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetRepository(int id)
        {
            var repository = _context.Repositories.FirstOrDefault(r => r.Id == id);

            if (repository == null)
            {
                return NotFound();
            }

            return Ok(repository);
        }

        [HttpPost]
        public IActionResult CreateRepository([FromBody] CreateRepositoryDto repositoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int currentUserId = 1;

            var repository = new Repository
            {
                Title = repositoryDto.Title,
                IsPublic = repositoryDto.IsPublic,
                OwnerId = currentUserId
            };

            _context.Repositories.Add(repository);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetRepository), new { id = repository.Id }, repository);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRepository(int id)
        {
            int currentUserId = 1;

            var repository = _context.Repositories.FirstOrDefault(r => r.Id == id);

            if (repository == null)
            {
                return NotFound();
            }

            if (repository.OwnerId != currentUserId)
            {
                return Forbid();
            }

            _context.Repositories.Remove(repository);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
