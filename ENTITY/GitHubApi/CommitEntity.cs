using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.GitHubApi
{
    public class CommitEntity
    {
        public string Sha { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
