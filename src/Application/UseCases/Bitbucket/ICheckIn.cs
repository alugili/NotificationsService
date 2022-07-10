namespace Bosch.CodeManagement.Extension.Application.UseCases.Bitbucket;

// https://developer.atlassian.com/cloud/bitbucket/rest/intro/

public interface ICheckIn
{
    /// <summary>
    /// Gets the sdk check in information.
    /// GET /2.0/repositories/{workspace}/{repo_slug}/commit/{commit}
    /// https://developer.atlassian.com/cloud/bitbucket/rest/api-group-commits/#api-repositories-workspace-repo-slug-commit-commit-get
    /// </summary>
    /// <param name="workspace">This can either be the workspace ID (slug) or the workspace UUID surrounded by curly-braces, for example: {workspace UUID}.</param>
    /// <param name="uuid">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: {repository UUID}</param>
    /// <param name="commit">The commit's SHA1</param>
    /// <returns>The commit object, in JSON format. <remarks>Read the given above documentations.</remarks></returns>
    public string GetCheckinInformation(string workspace, string uuid, string commit);

    /// <summary>
    /// Finds the related project to the SDK.
    /// Todo use query filter to find the related projects. 
    /// </summary>
    /// <param name="tag">Filter the search context.</param>
    /// <param name="workspaceUUID">The sdk workspace UUID.</param>
    /// <param name="repositoryUUID">The repository UUID.</param>
    /// <param name="jiraId">Jira Pull-Request Id or Index. Todo review if needed!</param>
    /// <returns>A list ob </returns>
    public ICollection<string> GetRelatedRepositories(string tag, string workspaceUUID, string repositoryUUID, string jiraId);

    /// <summary>
    /// Gets the pull request information.
    /// https://developer.atlassian.com/cloud/bitbucket/rest/api-group-pullrequests/#api-repositories-workspace-repo-slug-commit-commit-pullrequests-get
    /// </summary>
    /// <param name="workspace">This can either be the workspace ID (slug) or the workspace UUID surrounded by curly-braces, for example: {workspace UUID}.</param>
    /// <param name="uuid">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: {repository UUID}</param>
    /// <param name="commit">The commit's SHA1</param>
    /// <returns>The pull request JSON object. <remarks>Read the given above documentations.</remarks></returns>
    public string GetPullRequest(string workspace, string uuid, string commit, string pullRequestId);
}