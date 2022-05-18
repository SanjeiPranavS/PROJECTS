using FbConsoleApk.Model;

namespace FbConsoleApk.App_data.Repository;

internal class LikeDataHandler
{
    private static List<LikesMapper> _likes = Database.GetLikesList();

    public static List<LikesMapper> FetchUserLikesDetails(string postId)
    {
        return _likes.Where(like => like.PostUniqueId == postId).ToList();
    }


    public static void AddLikes(LikesMapper like)
    {
        _likes.Add(like);
    }

    public List<LikesMapper> FetchPostLikes(string postId)
    {
        return _likes.Where(temp => temp.PostUniqueId == postId).ToList();
    }

    public static int GetLikeCount(string uniquePostId)
    {
       return _likes.Count(like => like.PostUniqueId == uniquePostId);
    }

    public static bool UserReactionExist(string userUniqueId, string postUniqueId)
    {
        return _likes.Exists(like => like.UniqueId == userUniqueId && like.PostUniqueId == postUniqueId);
    }
}