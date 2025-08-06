using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeacherApi.Data;
using TeacherApi.Models;

namespace TeacherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<TeachersController> _logger;

        public TeachersController(AppDbContext context, ILogger<TeachersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
            try
            {
                _logger.LogInformation("Fetching teachers from the database.");
                var teachers = await _context.Teachers.ToListAsync();
                _logger.LogInformation($"Successfully fetched {teachers.Count} teachers.");
                return Ok(teachers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching teachers.");
                return StatusCode(500, "Internal server error: Could not fetch teachers.");
            }
        }
    }
}