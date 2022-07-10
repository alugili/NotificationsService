using Bosch.CodeManagement.Extension.Application.UseCases.Jira;
using Bosch.CodeManagement.Extension.NotificationAPI.Commands.Jira;
using Microsoft.AspNetCore.Mvc;

namespace Bosch.CodeManagement.Extension.NotificationAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class JiraController : ControllerBase
{
    private readonly ILogger<BitBucketController> _logger;

    [HttpPost]
    public async Task<IActionResult> GetCheckinInformation([FromQuery] PostIssueCommand command, [FromServices] IMediator mediator)
    {
        // todo
        IJiraIssuesManagement jiraIssuesManagement;
        var result = await mediator.Send(command);
        return Ok(result);
    }

    public JiraController(ILogger<BitBucketController> logger)
    {
        _logger = logger;
    }
}