using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Data
{
    public class IssueManager
    {
        public static List<Issue> Issues = new List<Issue>();
   
        public static void AddIssue(Issue issue)
        {

            Issues.Add(issue);
        }


        public static void AddIssue(string issue, PriorityValues priority,int userId)
        {
            long ticks = DateTime.Now.Ticks;
            Issue issue1 = new Issue();
            issue1.IssueDescription = issue;
            issue1.CreatedByUserId = userId;
            issue1.IssueId = ticks;
            issue1.PriorityValue = priority;
            UserManager.IncrementIssueCount(userId);
            IssueManager.AddIssue(issue1);
            

        }




        public static List<Issue> GetIssues(long issueId)
        {
            return Issues.FindAll(complain => complain.IssueId == issueId).ToList();
        }

        public static List<Issue> GetIssues(long issueId, int userId)
        {
            return Issues.FindAll(complain => complain.IssueId == issueId && complain.CreatedByUserId == userId);
        }

        public static bool IsIssueRemoved(long issueId)
        {
            return Issues.Remove(Issues.SingleOrDefault(temp => temp.IssueId == issueId));
        }

        public static List<Issue> FetchUserIssues(long userId)
        {
            return Issues.FindAll(issue => issue.CreatedByUserId == userId);
        }

        internal static List<Issue> FetchIssues()
        {
            return Issues;
        }
    }
}

