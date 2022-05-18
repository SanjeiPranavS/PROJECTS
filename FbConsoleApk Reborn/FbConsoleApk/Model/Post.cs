namespace FbConsoleApk.Model;

public class Post
{
    public string UserUniqueId { get; set; }
    public string UserName { get; set; }
    public string Image { get; set; }
    public string PostUniqueId { get; set; }
    public string PostDescription { get; set; } 

    
    public string GetUniquePostId()
    {
        return DateTime.Now.ToString("G");
    }
}