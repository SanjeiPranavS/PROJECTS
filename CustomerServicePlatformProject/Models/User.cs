using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Data;
namespace CustomerServicePlatformProject.Models
{
    public class User
    {
        
        public int userId { get; set; }

        public int NoOfIssuesPosted { get;  set; } = 0;
        public int NoOfCommentsPosted { get;  set; } = 0;

        public int NoOfSolutionsGiven { get;  set; } = 0;
        public int NoOfUpvotesGiven { get;  set; } = 0;
        public int NoOfDownvotesGiven { get; set; } = 0;

       
       
        
       
    }
}