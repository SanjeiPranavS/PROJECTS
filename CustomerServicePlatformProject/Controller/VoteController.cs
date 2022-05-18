using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Data;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Controller
{
    public class VoteController
    {
        public static void AddVote(User user, long issueId, string voteType)
        {
            VoteManager.AddIssueVote(voteType, issueId, user.userId);
        }
        public static List<Vote> GetList()
        {
            return VoteManager.VoteList;
        }
    }
}
