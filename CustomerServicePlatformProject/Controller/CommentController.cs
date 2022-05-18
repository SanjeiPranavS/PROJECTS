using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Data;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Controller
{
    public class CommentController
    {
        CommentManager commentManager = new CommentManager();   
        public static void AddComment(User user, long issueId, long parentCommentId, string comment)
        {
            CommentManager.AddUserComment(issueId, parentCommentId, comment, user.userId);
        }
        public static bool EditComment(long commentId, User user, string alteredComment)
        {
            foreach (var comment in CommentManager.CommentList)
            {
                if (comment.CreatedByUserId == user.userId && comment.CommentId == commentId)
                {
                    comment.CommentDescription = alteredComment;
                    return true;
                }

            }
            return false;
        }
        public static bool DeleteComment(long commentId)
        {
            return CommentManager.DeleteCommentList(commentId);
        }
        public static List<Comment> FetchComments()
        {
            return CommentManager.FetchComments();
        }
        public static List<Comment> FetchUserComment(int userId)
        {
            return CommentManager.FetchUserComment(userId);
        }
        public static List<Comment> FetchComment(long commentId)
        {
            return CommentManager.FetchComment(commentId);
        }
        public static List<Comment> GetList()
        {
            return CommentManager.CommentList;
        }
    }
    
}
