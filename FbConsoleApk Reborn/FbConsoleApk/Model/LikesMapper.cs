namespace FbConsoleApk.Model;

public class LikesMapper
{
    public string UniqueId { get; set; }
    public string UserName { get; set; }
    public string PostUniqueId { get; set; }
    public Reaction UserReaction { get; set; } 

    public LikesMapper(string uniqueId, string userName, string postUniqueId, Reaction userReaction)
    {
        UniqueId = uniqueId;
        UserName = userName;
        PostUniqueId = postUniqueId;
        UserReaction = userReaction;
    }

    public LikesMapper()
    {

    }

    public override string ToString()
    {
        return $"{UserName}  {UserReaction}";
    }
}

public enum Reaction
{
    Like,
    Heart,
    Laugh,
    Wow,
    Sad,
    Angry
}