using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Data
{
    public class SolutionManager
    {
        private static List<Solution> _solutionList = new List<Solution>();

        public static void AddIssueSolution(string solution, long issueId, int userId)
        {
            
                long ticks = DateTime.Now.Ticks;
                Solution solution1 = new Solution();
                solution1.IssueId = issueId;
                solution1.SolutionGiven = solution;
                solution1.UserId = userId;
                solution1.SolutionId = ticks;
                SolutionManager._solutionList.Add(solution1);

                UserManager.IncrementSolutionCount(userId);
                
                

            
        }

        public static List<Solution> GetSolutionList(long issueId)
        {
            return _solutionList.FindAll(temp => temp.IssueId == issueId);

        }
    }
}
