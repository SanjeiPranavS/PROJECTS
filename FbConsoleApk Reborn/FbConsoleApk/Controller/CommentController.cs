using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FbConsoleApk.App_data.Repository;
using FbConsoleApk.Model;
using FbConsoleApk.View;

namespace FbConsoleApk.Controller
{
    public class CommentController
    {
        public static void PrintPostComments(Post post)
        {
            var comments = CommentsDataHandler.FetchPostParentCmts(post.PostUniqueId);
            foreach (var cmts in comments)
            {
                CommentDisplayer.PrintPostComment(cmts);
            }
            Console.ReadKey();
        }

        public static Comment GetChildComment(string postId, string parentName)
        {
            var comments = CommentsDataHandler.FetchReplyComments(postId);
            return comments.Find(comment => comment.Parent == parentName);
        }
    }
}
