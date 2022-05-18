using System.Net.Sockets;
using FbConsoleApk.Model;

namespace FbConsoleApk.App_data.Repository;

internal class PostDataHandler
{
    private static List<Post> _posts = Database.GetListPost();

    public static void AddPost(Post post)
    {
        _posts.Add(post);
       
       
    }

    public IEnumerable<Post> GetUserPost(string userUniqueId)
    {
        foreach (var temp in _posts)
        {
            if (temp.UserUniqueId == userUniqueId)
            {
                yield return temp;
            }
        }
    }
    public static int GetNoOfPostCount(string uniqueUserId)
    {
        return _posts.Count(post => post.UserUniqueId == uniqueUserId);
    }
}