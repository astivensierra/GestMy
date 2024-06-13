using DLL;
using ENTITY.GitHubApi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class GitHubService
    {
        private readonly GitHubRepository _repository;

        public GitHubService(string token)
        {
            _repository = new GitHubRepository(token);
        }

        public async Task<IEnumerable<CommitEntity>> GetCommitsAsync(string owner, string repo, string branch)
        {
            return await _repository.GetCommitsAsync(owner, repo, branch);
        }

        public async Task<IEnumerable<BranchEntity>> GetBranchesAsync(string owner, string repo)
        {
            return await _repository.GetBranchesAsync(owner, repo);
        }

        public async Task<BranchEntity> GetBranchAsync(string owner, string repo, string branchName)
        {
            return await _repository.GetBranchAsync(owner, repo, branchName);
        }

        public async Task<RepositoryEntity> GetRepositoryAsync(string owner, string repo)
        {
            return await _repository.GetRepositoryAsync(owner, repo);
        }

        public async Task<IEnumerable<RepositoryEntity>> GetRepositoriesForUserAsync(string user)
        {
            return await _repository.GetRepositoriesForUserAsync(user);
        }

        public async Task<IEnumerable<IssueEntity>> GetIssuesAsync(string owner, string repo)
        {
            return await _repository.GetIssuesAsync(owner, repo);
        }

        public async Task<IssueEntity> CreateIssueAsync(string owner, string repo, string title, string body)
        {
            return await _repository.CreateIssueAsync(owner, repo, title, body);
        }

        public async Task<IEnumerable<PullRequestEntity>> GetPullRequestsAsync(string owner, string repo)
        {
            return await _repository.GetPullRequestsAsync(owner, repo);
        }

        public async Task<PullRequestEntity> GetPullRequestAsync(string owner, string repo, int number)
        {
            return await _repository.GetPullRequestAsync(owner, repo, number);
        }

        public async Task<IEnumerable<CollaboratorEntity>> GetCollaboratorsAsync(string owner, string repo)
        {
            return await _repository.GetCollaboratorsAsync(owner, repo);
        }

        public async Task<WebhookEntity> CreateWebhookAsync(string owner, string repo, string url, string contentType)
        {
            return await _repository.CreateWebhookAsync(owner, repo, url, contentType);
        }
    }
}
