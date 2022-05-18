namespace FbConsoleApk.Model;

public class Comment 
{
    public string UniqueId { get; set; }
    public string UserName { get; set; }
    public string UniqueCommentId { get; set; }
    public string Parent { get; set; }
    public string PostComment { get; set; }
    public string PostUniqueId { get; set; }

    public Comment(string uniqueId, string userName, string uniqueCommentId, string parent, string postComment, string postUniqueId)
    {
        UniqueId = uniqueId;
        UserName = userName;
        UniqueCommentId = uniqueCommentId;
        Parent = parent;
        PostComment = postComment;
        PostUniqueId = postUniqueId;
    }
    
}