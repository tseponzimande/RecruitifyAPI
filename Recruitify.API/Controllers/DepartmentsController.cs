namespace Recruitify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController(IApplicationDbContext context) : ControllerBase
    {
        private readonly IApplicationDbContext _context = context;

        #region Endpoints

        /// <summary>
        /// Get all departments with positions
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _context.Departments
                .Include(d => d.Positions)
                .ToListAsync();

            return Ok(departments);
        }

        #endregion
    }
}