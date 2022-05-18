using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Data
{
    public class CommentManager
    {
        public static List<Comment> CommentList = new List<Comment>();



        


        public static void AddComment(Comment comment1)
        {
            CommentList.Add(comment1);
        }

        public static void AddUserComment(long issueId, long commentId, string comment , int userId)
        {
            long ticks = DateTime.Now.Ticks;
            Comment comment1 = new Comment();
            comment1.CommentId = ticks;
            comment1.CreatedByUserId = userId;
            comment1.IssueId = issueId;
            comment1.ParentComment = commentId;
            comment1.CommentDescription = comment;
            CommentManager.AddComment(comment1);
            UserManager.IncrementCommentCount(userId);



        }

        internal static List<Comment> FetchComment(long commentId)
        {
            return CommentList.FindAll(comment => comment.CommentId == commentId);
        }

        internal static bool DeleteCommentList(long commentToBeDeleted)
        {
            return CommentList.Remove(CommentList.SingleOrDefault(temp => temp.CommentId == commentToBeDeleted));
        }

        public static List<Comment> FetchUserComment(int userId)
        { 
            return CommentList.FindAll(comment => comment.CreatedByUserId == userId);
        }
        public static List<Comment> FetchComments()
        {
            return CommentList;
        }
    }

}
