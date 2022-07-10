using Bosch.CodeManagement.Extension.Application.UseCases.Bitbucket;
using Bosch.CodeManagement.Extension.Application.UseCases.Jira;

namespace Bosch.CodeManagement.Extension.Infrastructure;

public class Todo
{
    private ICheckIn checkin;
    private INotifyUsers notfNotifyUsers;
    private IJiraIssuesManagement jiraIssuesManagement;

    public Todo(ICheckIn checkin, INotifyUsers notfNotifyUsers, IJiraIssuesManagement jiraIssuesManagement)
    {
        this.checkin = checkin;
        this.notfNotifyUsers = notfNotifyUsers;
        this.jiraIssuesManagement = jiraIssuesManagement;
    }
}