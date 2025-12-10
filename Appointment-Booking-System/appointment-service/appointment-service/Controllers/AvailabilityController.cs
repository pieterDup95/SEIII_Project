using appointment_service.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
[Authorize(Roles = "frontend")]
public class AvailabilityController : ControllerBase
{
    private readonly IBranchDetailService _branchService;
    private readonly ILogger<AvailabilityController> _logger;

    public AvailabilityController(IBranchDetailService branchService,ILogger<AvailabilityController> logger)
    {
        _branchService = branchService;
        _logger = logger;
    }

    [HttpGet("{branchId}/availability")]
    public async Task<IActionResult> GetAvailability(string branchId,[FromQuery] string date,CancellationToken cancellationToken)
    {
        _logger.LogInformation("Fetching availability for branch {BranchId} on date {Date}", branchId, date);
        if (!DateTime.TryParse(date, out var requestedDate))
            return BadRequest("Invalid date format. Use YYYY-MM-DD");

        var result = await _branchService.GetAvailabilityAsync(branchId, requestedDate, cancellationToken);
        return Ok(result);
    }
}