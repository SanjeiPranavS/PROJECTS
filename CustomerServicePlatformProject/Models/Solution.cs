using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServicePlatformProject.Models
{
    public class Solution
    {
        public long SolutionId { get; set; }


        public string SolutionGiven { get; set; }

        public int UserId { get; set; }

        public long IssueId { get; set; }
    }
}
