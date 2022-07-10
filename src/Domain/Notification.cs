namespace Bosch.CodeManagement.Extension.Domain;

public class Notification
{
    public Guid Id { get; set; }

    public string PullRequest { get; set; }

    public string FixInformation { get; set; }

    public ICollection<string> AffectedBitbucketUsers { get; set; }

    public ICollection<string> AffectedJiraProjects { get; set; }

    public DateTime Created { get; set; }
}