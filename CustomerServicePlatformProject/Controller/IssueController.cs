using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Data;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Controller
{
    public class IssueController
    {
        IssueManager issueManager = new IssueManager();
        public static void AddIssue(User user, string issue, PriorityValues priority)
        {
            IssueManager.AddIssue(issue, priority, user.userId);
        }
        public static bool EditIssue(long issueId, User user, string alteredIssue)
        {
            foreach(var issue in IssueManager.Issues)
            {
                if(issue.CreatedByUserId==user.userId && issue.IssueId == issueId)
                {
                    issue.IssueDescription = alteredIssue;
                    return true;
                }
                    
            }
            return false;
        }
        public static bool DeleteIssue(long issueId)
        {
            return IssueManager.IsIssueRemoved(issueId);
        }
        public static List<Issue> FetchIssues()
        {
            return IssueManager.Issues;
        }
        public static List<Issue> FetchUserIssues(long userId)
        {
            return IssueManager.FetchUserIssues(userId);
        }
        public static List<Issue> GetIssues(long issueId)
        {
            return IssueManager.GetIssues(issueId);
        }
        public static List<Issue> GetIssues(long issueId, int userId)
        {
            return IssueManager.GetIssues(issueId, userId);
        }
        public static bool IsIssueRemoved(long issueId)
        {
            return IssueManager.IsIssueRemoved(issueId);
        }
    }
}
