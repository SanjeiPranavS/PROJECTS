using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using CustomerServicePlatformProject.Models;
using CustomerServicePlatformProject.Controller;
namespace CustomerServicePlatformProject.View
{
   

    internal class Program
    {
        
        static void Main(string[] args)
        {
            string quit;
            Dictionary<int, long> starred = new Dictionary<int, long>();
            int count = 0;

            
            
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("****************************************WELCOME TO CUSTOMER SERVICE PLATFORM***************************************");
            Console.WriteLine("*******************************************************************************************************************");
            do
            {
                User user1;

                Console.WriteLine("==>Do you want to log in?\nEnter Yes or No");
                string login = Console.ReadLine();
                while (login == "Yes")
                {
                    int optionGiven;
                    Console.WriteLine("Enter your user id:");
                    var id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        if (!UserController.IsValidUser(id))
                            throw new Exception();

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid User Id");
                    }

                    user1 = UserController.FetchUserObj(id);
                    Console.WriteLine("*******************************************************************************************************************");
                    if (UserController.IsValidUser(id))
                    {


                        while (true)
                        {
                            
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("OPERATIONS AVAILABLE");
                            Console.WriteLine("1. Post an Issue\n2. Post a Comment for an issue\n3. Post a Reply to a comment\n4. Post a Solution to an issue\n5. Vote an Issue\n6. Edit an Issue\n7. Edit a Comment\n8. Delete an Issue\n9. Delete a comment\n10. Add star to an issue\n11. Logout");
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Enter your choice:");
                            optionGiven = Convert.ToInt32(Console.ReadLine());
                            if (optionGiven == 11) break;
                            switch (optionGiven)
                            {
                                case 1:
                                    {
                                        string issue;
                                        IssueController issueController = new IssueController();
                                        Console.WriteLine("Enter your issue");
                                        issue = Console.ReadLine();
                                        
                                        Console.WriteLine("Enter the priority of your issue as:\n=> High 1\n=> Medium 2\n=> Low 3");
                                        int priority = Convert.ToInt32((Console.ReadLine()));
                                        
                                        
                                            IssueController.AddIssue(user1,issue, (PriorityValues)priority);
                                        
                                        Console.WriteLine("*************************************************ISSUE POSTED SUCCESSFULLY**********************************************");
                                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                        break;
                                    }
                                case 2:
                                    {
                                        Thread thread1 = new Thread(DisplayIssues);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        long issueId;
                                        string comment;
                                        CommentController commentController = new CommentController();
                                        try
                                        {
                                            Console.WriteLine("Enter issue id");
                                            issueId = Convert.ToInt64(Console.ReadLine());
                                            var issues = IssueController.GetIssues(issueId);
                                            if (issues == null)
                                            {
                                                throw new Exception();
                                            }
                                            foreach (var issue in issues)
                                            {
                                                Console.WriteLine("Enter your comment");
                                                    comment = Console.ReadLine();
                                                    CommentController.AddComment(user1, issueId, 0, comment);
                                                    Console.WriteLine("*************************************************COMMENT POSTED SUCCESSFULLY**********************************************");
                                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                                    break;
                                                  
                                            }
                                            
                                        }
                                        catch (Exception )
                                        {
                                            Console.WriteLine("Issue Id is not found");
                                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        Thread thread1 = new Thread(DisplayComments);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        long commentId, issueId;
                                        string comment;
                                        try
                                        {
                                            Console.WriteLine("Enter comment id");
                                            commentId = Convert.ToInt64(Console.ReadLine());
                                            Console.WriteLine("Enter issueId of your comment");
                                            issueId = Convert.ToInt64(Console.ReadLine());
                                            if (CommentController.FetchComment(commentId) == null)
                                                throw new Exception();
                                            foreach (var comment1 in CommentController.FetchComment(commentId))
                                            {
                                                
                                                    Console.WriteLine("Enter your Reply");
                                                    comment = Console.ReadLine();
                                                    CommentController.AddComment(user1,issueId, commentId, comment);
                                                    Console.WriteLine("*************************************************REPLY POSTED SUCCESSFULLY**********************************************");
                                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                                    break;
                                             
                                            }

                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Comment Id is not found");
                                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        Thread thread1 = new Thread(DisplayIssues);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        long issueId;
                                        string solution;
                                        try
                                        {
                                            Console.WriteLine("Enter issue id");
                                            issueId = Convert.ToInt64(Console.ReadLine());
                                            var issues = IssueController.GetIssues(issueId);
                                            if (issues == null)
                                            {
                                                throw new Exception();
                                            }
                                            foreach (var item in issues)
                                            {
                                               
                                                    Console.WriteLine("Enter your comment");
                                                    solution = Console.ReadLine();
                                                    SolutionController.AddSolution(user1, issueId, solution);
                                                    Console.WriteLine("*************************************************SOLUTION POSTED SUCCESSFULLY**********************************************");
                                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                                    break;
                                               
                                            }

                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Issue Id is not found");
                                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                        }
                                        
                                        break;
                                    }
                                case 5:
                                    {
                                        Thread thread1 = new Thread(DisplayIssues);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        long issueId;
                                        string voteType;
                                        Console.WriteLine("Enter issue id");
                                        issueId = Convert.ToInt64(Console.ReadLine());
                                        Console.WriteLine("Enter your vote_type");
                                        voteType = Console.ReadLine();

                                        VoteController.AddVote(user1, issueId,voteType);
                                        break;
                                    }
                                case 6:
                                    {
                                        long issueId;
                                        Thread thread1 = new Thread(DisplayIssues);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        Console.WriteLine("Enter the Id of the issue to be edited: ");
                                        issueId = Convert.ToInt64(Console.ReadLine());
                                        var issues = IssueController.GetIssues(issueId,user1.userId);
                                       
                                        foreach (var issue in issues)
                                        {
                                            
                                                string alteredIssueDescription;
                                                Console.WriteLine("Original issue description:\n" + issue.IssueDescription);
                                                Console.WriteLine("Enter your altered issue description:");
                                                alteredIssueDescription = Console.ReadLine();
                                                issue.IssueDescription = alteredIssueDescription;
                                            
                                        }
                                        break;
                                    }
                                case 7:
                                    {
                                        long commentId;
                                        Thread thread1 = new Thread(DisplayComments);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        Console.WriteLine("Enter the Id of the comment to be edited: ");
                                        commentId = Convert.ToInt64(Console.ReadLine());

                                        foreach (var comment in CommentController.FetchComment(commentId))
                                        {
                                            if (comment.CommentId == commentId && comment.CreatedByUserId == user1.userId)
                                            {
                                                string alteredIssueDescription;
                                                Console.WriteLine("Original comment description:\n" + comment.CommentDescription);
                                                Console.WriteLine("Enter altered comment description:");
                                                alteredIssueDescription = Console.ReadLine();
                                                comment.CommentDescription = alteredIssueDescription;
                                            }
                                        }
                                        break;
                                    }
                                case 8:
                                    {
                                        long issueToBeDeleted;

                                        Thread thread1 = new Thread(DisplayIssues);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        Console.WriteLine("Enter the issue id to be deleted");
                                        issueToBeDeleted = Convert.ToInt64(Console.ReadLine());

                                        if(!IssueController.IsIssueRemoved(issueToBeDeleted)) 
                                            Console.WriteLine("Invalid operation");
                                        break;
                                    }
                                case 9:
                                    {
                                        long commentToBeDeleted;

                                        Thread thread1 = new Thread(DisplayComments);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        Console.WriteLine("Enter the comment id to be deleted:");
                                        commentToBeDeleted = Convert.ToInt64(Console.ReadLine());
                                         
                                        if (!CommentController.DeleteComment(commentToBeDeleted))

                                            Console.WriteLine("Invalid operation");
                                        break;
                                    }
                                case 10:
                                    {
                                        Thread thread1 = new Thread(DisplayIssues);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        long issueId;

                                        Console.WriteLine("Enter issue id");
                                        issueId = Convert.ToInt64(Console.ReadLine());
                                        count++;
                                        starred.Add(count, issueId);
                                        break;
                                    }
                            }


                        }
                        Console.WriteLine("--------------------------------Logout Successful-------------------------------------");
                     
                        int option;

                        do
                        {

                            Console.WriteLine("***********************************************OPERATIONS AVAILABLE FOR ISSUES*****************************************");
                            Console.WriteLine("1.List all the Issues\n2.List all the comments \n3.Display all the issues posted by an user\n4. Display all the comments posted by an user\n5. Display the Number of Upvotes for an issue\n6. Display the Number of Downvotes for an issue\n7. Display the Solutions for an issue\n8. Finish");
                            option = Convert.ToInt32(Console.ReadLine());
                            if (option == 8) break;
                            switch (option)
                            {
                                case 1:
                                    {
                                        Thread thread1 = new Thread(DisplayIssues);
                                        thread1.Priority = ThreadPriority.Highest;
                                        thread1.Start();
                                        thread1.Join();
                                        break;
                                    }
                                case 2:
                                    {
                                        Thread t1 = new Thread(DisplayComments);
                                        t1.Priority = ThreadPriority.Highest;
                                        t1.Start();
                                        t1.Join();
                                        break;
                                    }
                                case 3:
                                    {
                                         long userId;
                                        Console.WriteLine("Enter the userId");
                                        userId = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("        id        |           Issue Description           | user Posted the issue |      date time         |   Priority ");
                                        
                                        foreach (var issue in IssueController.FetchUserIssues(userId))
                                        {
                                           
                                                Console.WriteLine(issue.IssueId + " | " + issue.IssueDescription + " | " + issue.CreatedByUserId + " | " + issue.DateTime + " | " + (int)issue.PriorityValue);
                                        }
                                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                        break;
                                    }
                                case 4:
                                    {
                                        int userId;
                                        Console.WriteLine("Enter the userId");
                                        userId = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Comments posted :-");
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine("comment.id  |   Comment      |    user posted    |    Issue.id       |    commentedOnId  ");
                                        foreach (var comment1 in CommentController.FetchUserComment(userId))
                                        {
                                            
                                                Console.WriteLine(comment1.CommentId + " | " + comment1.CommentDescription + " | " + comment1.CreatedByUserId + " | " + comment1.IssueId + " | " + comment1.ParentComment);
                                        }
                                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                        break;
                                    }
                                case 5:
                                    {
                                        long issueId;
                                        int countOfUpvotes = 0;
                                        Console.WriteLine("Enter the Issue id:");
                                        issueId = Convert.ToInt64(Console.ReadLine());
                                        foreach (var vote in VoteController.GetList())
                                        {
                                            if (vote.IssueId == issueId && vote.VoteType == "Upvoted") countOfUpvotes++;
                                        }
                                        Console.WriteLine("Number of Upvotes :" + countOfUpvotes);
                                        break;
                                    }
                                case 6:
                                    {
                                        long issueId;
                                        int countOfDownvotes = 0;
                                        Console.WriteLine("Enter the Issue id:");
                                        issueId = Convert.ToInt64(Console.ReadLine());
                                        foreach (var vote in VoteController.GetList())
                                        {
                                            if (vote.IssueId == issueId && vote.VoteType == "Downvoted") countOfDownvotes++;
                                        }
                                        Console.WriteLine("Number of Downvotes :" + countOfDownvotes);
                                        break;
                                    }
                                case 7:
                                    {
                                        long issueId;

                                        Console.WriteLine("Enter the Issue id:");
                                        issueId = Convert.ToInt64(Console.ReadLine());
                                        Console.WriteLine("Id        |       Solution Description                      |                      User Id                  |        Issue Id");
                                        foreach (var solution in SolutionController.GetSolutionList(issueId))
                                        {
                                           
                                                Console.WriteLine(solution.SolutionId + " | " + solution.SolutionGiven + " | " + solution.UserId + " | " + solution.IssueId);
                                        }

                                        break;
                                    }
                                case 8:
                                    break;
                            }
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                        } while (option != 8);
                        if (optionGiven == 11)
                            break;
                    }
                }
                foreach (User user in UserController.GetList())
                {
                    Console.WriteLine("Activities of "+user.userId + "\nNumber of issues posted: " + user.NoOfIssuesPosted + "\nNumber of comments posted: " + user.NoOfCommentsPosted + "\nNumber of Solutions given: " + user.NoOfSolutionsGiven + "\nNumber of Upvotes given: " + user.NoOfUpvotesGiven + "\nNumber of Downvotes given: " + user.NoOfDownvotesGiven);
                }
                
                

                Console.WriteLine("==>Do you want to quit?\n Enter Yes or No");
               quit = Console.ReadLine();


            } while (quit == "No");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("*******************************************THANK YOU FOR AVAILING OUR SERVICE. BYE*************************************");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        }

      

        public static void DisplayIssues()
        {
            Console.WriteLine("Issues posted :-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("        id        |           Issue Description           | user Posted the issue |      date time         |   Priority ");
            foreach (var issue in IssueController.FetchIssues())
            {
                Console.WriteLine(issue.IssueId + "| " + issue.IssueDescription + " | " + issue.CreatedByUserId + " | " + issue.DateTime + " | " + issue.PriorityValue);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }
        public static void DisplayComments()
        {
            Console.WriteLine("Comments posted :-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    comment.id     |                Comment       |user posted|    Issue id       |    Parent Comment  ");
            foreach (var comment1 in CommentController.GetList())
            {
                Console.WriteLine(comment1.CommentId + " | " + comment1.CommentDescription + " | " + comment1.CreatedByUserId + " | " + comment1.IssueId + " | " + comment1.ParentComment);

            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }

    }
}
