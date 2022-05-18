using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Data;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Controller
{
    public class SolutionController
    {
        SolutionManager solutionManager = new SolutionManager();
        public static void AddSolution(User user, long issueId, string solution)
        {
            SolutionManager.AddIssueSolution(solution, issueId, user.userId);
        }
        public static List<Solution> GetSolutionList(long issueId)
        {
            return SolutionManager.GetSolutionList(issueId);

        }
    }
}
