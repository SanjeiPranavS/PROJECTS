using FbConsoleApk.Model;

namespace FbConsoleApk.App_data.Repository;

internal class CommentsDataHandler
{
    private static  List<Comment> _comments = Database.GetListComments();

    public static List<Comment> FetchPostParentCmts(string postUniqueId)
    {
        return _comments.Where(temp => temp.PostUniqueId == postUniqueId && string.IsNullOrEmpty(temp.Parent)).ToList();
    }

    public static List<Comment> FetchReplyComments(string postId)
    {
        return _comments.Where(temp => temp.PostUniqueId == postId).ToList();
    }

    public static int GetCommentCount(string postUniqueId)
    {
       return _comments.Count(cmt => cmt.PostUniqueId == postUniqueId && string.IsNullOrWhiteSpace(cmt.Parent));
    }
}