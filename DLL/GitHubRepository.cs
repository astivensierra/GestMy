using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ENTITY.GitHubApi;
using Octokit;

namespace DLL
{
    public class GitHubRepository
    {
        private readonly Octokit.GitHubClient _client;

        public GitHubRepository(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentNullException(nameof(token));

            _client = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("YourAppName"))
            {
                Credentials = new Credentials(token)
            };
        }

        public async Task<IEnumerable<CommitEntity>> GetCommitsAsync(string owner, string repo, string branch)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));
            if (string.IsNullOrEmpty(branch)) throw new ArgumentNullException(nameof(branch));

            var commits = await _client.Repository.Commit.GetAll(owner, repo, new Octokit.CommitRequest { Sha = branch });
            var commitEntities = new List<CommitEntity>();

            foreach (var commit in commits)
            {
                commitEntities.Add(new CommitEntity
                {
                    Sha = commit.Sha,
                    Author = commit.Commit.Author.Name,
                    Date = commit.Commit.Author.Date.DateTime,
                    Message = commit.Commit.Message
                });
            }

            return commitEntities;
        }

        public async Task<IEnumerable<BranchEntity>> GetBranchesAsync(string owner, string repo)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));

            var branches = await _client.Repository.Branch.GetAll(owner, repo);
            var branchEntities = new List<BranchEntity>();

            foreach (var branch in branches)
            {
                branchEntities.Add(new BranchEntity
                {
                    Name = branch.Name
                });
            }

            return branchEntities;
        }

        public async Task<BranchEntity> GetBranchAsync(string owner, string repo, string branchName)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));
            if (string.IsNullOrEmpty(branchName)) throw new ArgumentNullException(nameof(branchName));

            var branch = await _client.Repository.Branch.Get(owner, repo, branchName);
            return new BranchEntity { Name = branch.Name };
        }

        public async Task<RepositoryEntity> GetRepositoryAsync(string owner, string repo)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));

            var repository = await _client.Repository.Get(owner, repo);
            return new RepositoryEntity
            {
                Name = repository.Name,
                Description = repository.Description,
                Url = repository.HtmlUrl
            };
        }

        public async Task<IEnumerable<RepositoryEntity>> GetRepositoriesForUserAsync(string user)
        {
            if (string.IsNullOrEmpty(user)) throw new ArgumentNullException(nameof(user));

            var repositories = await _client.Repository.GetAllForUser(user);
            var repositoryEntities = new List<RepositoryEntity>();

            foreach (var repo in repositories)
            {
                repositoryEntities.Add(new RepositoryEntity
                {
                    Name = repo.Name,
                    Description = repo.Description,
                    Url = repo.HtmlUrl
                });
            }

            return repositoryEntities;
        }

        public async Task<IEnumerable<IssueEntity>> GetIssuesAsync(string owner, string repo)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));

            var issues = await _client.Issue.GetAllForRepository(owner, repo);
            var issueEntities = new List<IssueEntity>();

            foreach (var issue in issues)
            {
                issueEntities.Add(new IssueEntity
                {
                    Id = (int)issue.Id, // Converting long to int
                    Title = issue.Title,
                    Body = issue.Body,
                    State = issue.State.StringValue,
                    CreatedAt = issue.CreatedAt.DateTime
                });
            }

            return issueEntities;
        }

        public async Task<IssueEntity> CreateIssueAsync(string owner, string repo, string title, string body)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException(nameof(title));
            if (string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));

            var newIssue = new NewIssue(title) { Body = body };
            var issue = await _client.Issue.Create(owner, repo, newIssue);

            return new IssueEntity
            {
                Id = (int)issue.Id, // Converting long to int
                Title = issue.Title,
                Body = issue.Body,
                State = issue.State.StringValue,
                CreatedAt = issue.CreatedAt.DateTime
            };
        }

        public async Task<IEnumerable<PullRequestEntity>> GetPullRequestsAsync(string owner, string repo)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));

            var pullRequests = await _client.PullRequest.GetAllForRepository(owner, repo);
            var pullRequestEntities = new List<PullRequestEntity>();

            foreach (var pr in pullRequests)
            {
                pullRequestEntities.Add(new PullRequestEntity
                {
                    Number = pr.Number,
                    Title = pr.Title,
                    State = pr.State.StringValue,
                    Body = pr.Body,
                    CreatedAt = pr.CreatedAt.DateTime
                });
            }

            return pullRequestEntities;
        }

        public async Task<PullRequestEntity> GetPullRequestAsync(string owner, string repo, int number)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));

            var pr = await _client.PullRequest.Get(owner, repo, number);
            return new PullRequestEntity
            {
                Number = pr.Number,
                Title = pr.Title,
                State = pr.State.StringValue,
                Body = pr.Body,
                CreatedAt = pr.CreatedAt.DateTime
            };
        }

        public async Task<IEnumerable<CollaboratorEntity>> GetCollaboratorsAsync(string owner, string repo)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));

            var collaborators = await _client.Repository.Collaborator.GetAll(owner, repo);
            var collaboratorEntities = new List<CollaboratorEntity>();

            foreach (var collaborator in collaborators)
            {
                collaboratorEntities.Add(new CollaboratorEntity
                {
                    Login = collaborator.Login,
                    Url = collaborator.HtmlUrl
                });
            }

            return collaboratorEntities;
        }

        public async Task<WebhookEntity> CreateWebhookAsync(string owner, string repo, string url, string contentType)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException(nameof(owner));
            if (string.IsNullOrEmpty(repo)) throw new ArgumentNullException(nameof(repo));
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            if (string.IsNullOrEmpty(contentType)) throw new ArgumentNullException(nameof(contentType));

            var newHook = new NewRepositoryHook("web", new Dictionary<string, string>
            {
                { "url", url },
                { "content_type", contentType }
            });
            var hook = await _client.Repository.Hooks.Create(owner, repo, newHook);
            return new WebhookEntity
            {
                Id = hook.Id.ToString(),
                Url = hook.Config["url"],
                ContentType = hook.Config["content_type"]
            };
        }
    }
}
