using Bosch.CodeManagement.Extension.Application.UseCases.Bitbucket;
using Bosch.CodeManagement.Extension.NotificationAPI.Commands.Bitbucket;
using Microsoft.AspNetCore.Mvc;

namespace Bosch.CodeManagement.Extension.NotificationAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BitBucketController : ControllerBase
{
    private readonly ILogger<BitBucketController> _logger;

    [HttpGet]
    public async Task<IActionResult> GetCheckinInformation([FromQuery] GetCheckinInformationCommand command, [FromServices] IMediator mediator)
    {
        // todo
        ICheckIn checkIn;
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetRelatedRepositories([FromQuery] GetRelatedRepositoriesCommand command, [FromServices] IMediator mediator)
    {
        // todo
        ICheckIn checkIn;
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetPullRequest([FromQuery] GetPullRequestCommand command, [FromServices] IMediator mediator)
    {
        // todo
        ICheckIn checkIn;
        var result = await mediator.Send(command);
        return Ok(result);
    }

    public BitBucketController(ILogger<BitBucketController> logger)
    {
        _logger = logger;
    }
}