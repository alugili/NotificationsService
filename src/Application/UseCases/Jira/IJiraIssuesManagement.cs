namespace Bosch.CodeManagement.Extension.Application.UseCases.Jira;

public interface IJiraIssuesManagement
{
    public ICollection<string> CreateInIssue(string projectName, string relatedProjects, string description, string checkinId);
}