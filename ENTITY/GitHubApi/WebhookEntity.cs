using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.GitHubApi
{
    public class WebhookEntity
    {
        public string Id { get; set; } = String.Empty;
        public string Url { get; set; } = String.Empty;
        public string ContentType { get; set; } = String.Empty;
    }
}
