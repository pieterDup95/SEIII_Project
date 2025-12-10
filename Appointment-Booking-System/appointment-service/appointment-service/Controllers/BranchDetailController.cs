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
        _logger.LogInformation("Fetching branches with search term: {SearchTerm}", search);
        var branches = await _service.GetAllBranchesAsync(search, cancellationToken);
        return Ok(branches);
    }

    [HttpGet("operational-hours")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OperationalHoursDto>))]
    public async Task<ActionResult<List<OperationalHoursDto>>> GetAllOperationalHours(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Fetching all operational hours");
        var hours = await _service.GetAllOperationalHoursAsync(cancellationToken);
        return Ok(hours);
    }
}