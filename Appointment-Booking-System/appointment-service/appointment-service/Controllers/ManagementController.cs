using appointment_service.Controllers.Models;
using appointment_service.Persistence.Repositories;
using appointment_service.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace appointment_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "admin")]
    public class ManagementController : ControllerBase
    {

        private readonly ILogger<ManagementController> _logger;
        private readonly IManagementService _managementService;
        public ManagementController(ILogger<ManagementController> logger, IManagementService managementService)
        {
            _logger = logger;
            _managementService = managementService;
        }


        [HttpPost("CreateBranch")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(BranchDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateBranch([FromBody] CreateBranchDto createDto, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Creating new branch: {BranchName}", createDto.BranchName);
                var createdBranch = await _managementService.CreateBranchAsync(createDto, cancellationToken);
                if (createdBranch == null)
                    return BadRequest(new { Message = "Branch could not be created." });

                return Created(string.Empty, createdBranch);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating branch");
                return StatusCode(500, new { Message = "An unexpected error occurred." });
            }
        }

        [HttpPost("CreateOperationalHours")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(OperationalHoursDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateOperationalHours([FromBody] CreateOperationalHoursDto dto, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Creating operational hours for Branch ID: {BranchId}", dto.BranchId);
                var created = await _managementService.CreateOperationalHoursAsync(dto, cancellationToken);
                if (created == null)
                    return BadRequest(new { Message = "Operational hours could not be created." });

                return CreatedAtAction(nameof(CreateOperationalHours), new { }, created);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating operational hours");
                return StatusCode(500, new { Message = "An unexpected error occurred." });
            }
        }
    }
}
