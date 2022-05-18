using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServicePlatformProject.Models
{
    public class Comment
    {
        public long CommentId { get; set; }

        public string CommentDescription { get; set; }

        public int CreatedByUserId { get; set; }

        public long ParentComment { get; set; }

        public long IssueId { get; set; }
    }
}
