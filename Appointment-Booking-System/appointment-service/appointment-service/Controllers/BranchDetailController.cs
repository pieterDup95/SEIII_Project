using appointment_service.Controllers;
using appointment_service.Controllers.Models;
using appointment_service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Authorize(Roles = "frontend")]
public class BranchDetailController : ControllerBase
{
    private readonly ILogger<BranchDetailController> _logger;
    private readonly IBranchDetailService _service;

    public BranchDetailController(ILogger<BranchDetailController> logger, IBranchDetailService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet("branches")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<BranchDto>))]
    public async Task<ActionResult<List<BranchDto>>> GetBranches([FromQuery] string? search, CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Fetching branches with search term: {SearchTerm}", search);
            var branches = await _service.GetAllBranchesAsync(search, cancellationToken);
            return Ok(branches);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching branches");
            return StatusCode(500, new
            {
                error = "ServerError",
                message = "An unexpected error occurred. Please try again later."
            });
        }
    }

    [HttpGet("operational-hours")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OperationalHoursDto>))]
    public async Task<ActionResult<List<OperationalHoursDto>>> GetAllOperationalHours(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Fetching all operational hours");
            var hours = await _service.GetAllOperationalHoursAsync(cancellationToken);
            return Ok(hours);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching operational hours");
            return StatusCode(500, new
            {
                error = "ServerError",
                message = "An unexpected error occurred. Please try again later."
            });
        }
    }
}