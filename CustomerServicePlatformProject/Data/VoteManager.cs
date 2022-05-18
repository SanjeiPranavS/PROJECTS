using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Data
{
    public class VoteManager
    {
        public static List<Vote> VoteList = new List<Vote>();

        internal static void AddIssueVote(string voteType, long issueId, int userId)
        {
           
                long ticks = DateTime.Now.Ticks;
                Vote vote = new Vote();
                vote.VoteId = ticks;
                vote.VoteType = voteType;
                vote.IssueId = issueId;
                vote.UserIdVoted = userId;
                VoteManager.VoteList.Add(vote);
                if (voteType == "Upvoted")

                    UserManager.IncrementUpVotesGiven(userId);


                else if (voteType == "Downvoted")

                    UserManager.IncrementDownVotesGiven(userId);










                









                       
               

            
        }
    }
}
