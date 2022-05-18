using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServicePlatformProject.Models
{
    public class Vote
    {
        public long VoteId { get; set; }


        public string VoteType { get; set; }

        public int UserIdVoted { get; set; }

        public long IssueId { get; set; }
    }
}
