using FbConsoleApk.Model;

namespace FbConsoleApk.App_data;

internal class Database
{
    public static List<User> GetUsersList()
    {
        var users = new List<User>();
        users.Add(new User()
        {
            UniqueId = "Sanjei2002",
            UserName = "Sanjei Pranav",
            Gender = Gender.Male,
            DateOfBirth = new DateTime(2002, 04, 11),
            
        });
        users.Add(new User()
        {
            UniqueId = "Rajesh2022",
            UserName = "Rajesh",
            Gender = Gender.Male,
            DateOfBirth = new DateTime(2002, 05, 18),
           
        });
        return users;
    }

    public static List<LikesMapper> GetLikesList()
    {
        var likes = new List<LikesMapper>();

        likes.Add(new LikesMapper("saanji422", "Saanji", "post12002", Reaction.Like));
        likes.Add(new LikesMapper("zoro3434", "zoro", "post12002", Reaction.Like));
        likes.Add(new LikesMapper("luffy344", "luffy", "post12002", Reaction.Heart));
        likes.Add(new LikesMapper("naami7249", "nami", "post12002", Reaction.Like));
        likes.Add(new LikesMapper("brook4242", "brook", "post12002", Reaction.Heart));
        likes.Add(new LikesMapper("franky9374", "Franky", "post12002", Reaction.Laugh));
        likes.Add(new LikesMapper("saanji422", "Saanji", "post22002", Reaction.Like));
        likes.Add(new LikesMapper("zoro3434", "zoro", "post22002", Reaction.Like));
        likes.Add(new LikesMapper("luffy344", "luffy", "post22002", Reaction.Heart));
        likes.Add(new LikesMapper("naami7249", "nami", "post22002", Reaction.Like));
        likes.Add(new LikesMapper("brook4242", "brook", "post22002", Reaction.Heart));
        likes.Add(new LikesMapper("franky9374", "Franky", "post22002", Reaction.Laugh));
        likes.Add(new LikesMapper("naruto2322", "Naruto", "post22002", Reaction.Sad));
        likes.Add(new LikesMapper("brook4242", "brook", "post32002", Reaction.Heart));
        likes.Add(new LikesMapper("luffy344", "luffy", "post32002", Reaction.Heart));
        likes.Add(new LikesMapper("naami7249", "nami", "post32002", Reaction.Like));
        likes.Add(new LikesMapper("franky9374", "Franky", "post32002", Reaction.Laugh));
        likes.Add(new LikesMapper("naruto2322", "Naruto", "post42002", Reaction.Sad));
        likes.Add(new LikesMapper("saanji422", "jiraya", "post42002", Reaction.Like));
        likes.Add(new LikesMapper("zoro3434", "gintama", "post42002", Reaction.Like));
        likes.Add(new LikesMapper("naruto2322", "ram", "post42002", Reaction.Sad));
        likes.Add(new LikesMapper("saanji422", "sam", "post42002", Reaction.Like));
        likes.Add(new LikesMapper("zoro3434", "ben", "post42002", Reaction.Like));
        likes.Add(new LikesMapper("naruto2322", "quven", "post42002", Reaction.Sad));
        likes.Add(new LikesMapper("saanji422", "rajesh", "post42002", Reaction.Like));
        likes.Add(new LikesMapper("zoro3434", "mahesh", "post42002", Reaction.Like));
        likes.Add(new LikesMapper("luffy344", "Ace", "post42002", Reaction.Heart));
        likes.Add(new LikesMapper("zoro3434", "gintama", "post52002", Reaction.Like));
        likes.Add(new LikesMapper("naruto2322", "ram", "post52002", Reaction.Sad));
        likes.Add(new LikesMapper("saanji422", "sam", "post52002", Reaction.Like));
        likes.Add(new LikesMapper("zoro3434", "ben", "post52002", Reaction.Like));
        likes.Add(new LikesMapper("user123123", "User3", "post12022", Reaction.Like));
        likes.Add(new LikesMapper("user342123", "User4", "post12022", Reaction.Angry));
        likes.Add(new LikesMapper("user12345123", "User56", "post22022", Reaction.Like));
        likes.Add(new LikesMapper("user3425423", "User34", "post22022", Reaction.Sad));
        likes.Add(new LikesMapper("user123123", "User6", "post22022", Reaction.Like));
        likes.Add(new LikesMapper("user342123", "User4", "post22022", Reaction.Angry));
        likes.Add(new LikesMapper("user12345123", "User56", "post32022", Reaction.Like));
        likes.Add(new LikesMapper("user3425423", "User34", "post32022", Reaction.Sad));
        likes.Add(new LikesMapper("user123123", "User6", "post32022", Reaction.Like));
        likes.Add(new LikesMapper("user342123", "User4", "post32022", Reaction.Angry));
        likes.Add(new LikesMapper("user12345123", "User57", "post32022", Reaction.Like));
        likes.Add(new LikesMapper("user3425423", "User97", "post32022", Reaction.Sad));
        likes.Add(new LikesMapper("user123123", "User3", "post32022", Reaction.Like));
        likes.Add(new LikesMapper("user342123", "User98", "post32022", Reaction.Angry));
        likes.Add(new LikesMapper("user123123", "User57", "post32022", Reaction.Like));
        likes.Add(new LikesMapper("user342123", "User37", "post32022", Reaction.Angry));


        return likes;
    }

    public static List<Post> GetListPost()
    {
        var posts = new List<Post>();
        posts.Add(new Post
        {
            PostUniqueId = "post12002",
            UserUniqueId = "Sanjei2002",
            UserName = "Sanjei Pranav",
            Image = "crackers",
            PostDescription = "Happy diwali folks...",
          
        });
        posts.Add(new Post
        {
            PostUniqueId = "post22002",
            UserUniqueId = "Sanjei2002",
            UserName = "Sanjei Pranav",
            Image = "cake",
            PostDescription = "Many More Happy returns of the day",
          
        });
        posts.Add(new Post
        {
            PostUniqueId = "post32002",
            UserUniqueId = "Sanjei2002",
            UserName = "Sanjei Pranav",
            Image = "pongal",
            PostDescription = "Happy tamil pongal everyone",
         
        });
        posts.Add(new Post
        {
            PostUniqueId = "post42002",
            UserUniqueId = "Sanjei2002",
            UserName = "Sanjei Pranav",
            Image = "Dog",
            PostDescription = "Baby dog, new member to the family",
        
        });
        posts.Add(new Post
        {
            PostUniqueId = "post52002",
            UserUniqueId = "Sanjei2002",
            UserName = "Sanjei Pranav",
            Image = "vibes",
            PostDescription = "POsitive vibes forever",
         
        });
        posts.Add(new Post
        {
            PostUniqueId = "post12022",
            UserUniqueId = "Rajesh2022",
            UserName = "Rajesh",
            Image = "<some post>",
            PostDescription = "some post discription made by <user>",
        
        });
        posts.Add(new Post
        {
            PostUniqueId = "post22022",
            UserUniqueId = "Rajesh2022",
            UserName = "Rajesh",
            Image = "<some post2.0>",
            PostDescription = "some post discription made by <user>",
          
        });
        posts.Add(new Post
        {
            PostUniqueId = "post32022",
            UserUniqueId = "Rajesh2022",
            UserName = "Rajesh",
            Image = "<some post 3.0>",
            PostDescription = "some post discription made by <user>",
       
        });
        return posts;
    }

    public static List<Comment> GetListComments()
    {
        var comments = new List<Comment>();
        comments.Add(new Comment("luffy098", "luffy", "p1c1r0", null, "Have a great diwali today", "post12002"));
        comments.Add(new Comment("Sanjei2002", "Sanjei Pranav", "p1c1r1", "p1c1r0", "thank you bro", "post12002"));
        comments.Add(new Comment("luffy098", "luffy", "p1c1r2", "p1c1r1", "Welcome bro ", "post12002"));
        comments.Add(new Comment("Franky567", "Franky", "p1c2r0", null, "Safely enjoy diwali ", "post12002"));
        comments.Add(new Comment("Sanjei2002", "Sanjei Pranav", "p1c2r1", "p1c2r0", "you too bro", "post12002"));
        comments.Add(new Comment("Ram2345", "Ram", "p1c3r0", null, "Happy diwali Sanjei pranav", "post12002"));
        comments.Add(new Comment("Ramesh24231", "Ramesh ", "p1c4r0", null, "Happy holidays", "post12002"));

        comments.Add(new Comment("VTsaran0239", "VTsaran", "p2c1r0", null, "Happy birthday SANJEI PRANAV", "post22002"));
        comments.Add(new Comment("Sanjei23233", "Sanjei pranav", "p2c1r1", "p2c1r0", "Thank you VTsaran", "post22002"));
        comments.Add(new Comment("VTsaran0239", "VTsaran", "p2c1r2", "p2c1r1", "Marakama treat vachuru", "post22002"));
        comments.Add(new Comment("Sanjei23233", "Sanjei Pranav", "p2c1r3", "p2c1r2", "OK bro vacharlam", "post22002"));
        comments.Add(new Comment("Rajesh23233", "Rajesh", "p2c2r0", null, "Many more happy returns of the day ", "post22002"));
        comments.Add(new Comment("Sanjei23233", "Sanjei Pranav", "p2c2r1", "p2c2r0", "Thank you bro it means a lot ", "post22002"));
        comments.Add(new Comment("Naruto231313", "Naruto", "p2c3r0", null, "Have a beautiful and wonderful day", "post22002"));
        comments.Add(new Comment("MInato232332", "Minato", "p2c4r0", null, "Happy birthday Supreme", "post22002"));
        comments.Add(new Comment("Jiraya2231r46", "Jiraya", "p2c5r0", null, "Many more happy returns of the day SANJEI PRANAV", "post22002"));

        comments.Add(new Comment("Rakesh32323", "Rakesh", "p3c1r0", null, "Happy pongal bro", "post32002"));
        comments.Add(new Comment("balaji23232", "balajiprasanth", "p3c2r0", null, "thai thhiru nall nal valthukal", "post32002"));
        comments.Add(new Comment("shiva42424", "Shiva Prasath", "p3c3r0", null, "celebrate pongal in style", "post32002"));
        comments.Add(new Comment("Sanjei35756", "Sanjei Pranav ", "p2c3r1", "p3c3r0", "sure bro", "post32002"));
        comments.Add(new Comment("seeni435214", "SeeniDurai", "p2c4r0", null, "Pongalo pongal", "post32002"));
        comments.Add(new Comment("Jiraya2231r46", "Jiraya", "p2c5r0", null, "wish you a happy pongal", "post32002"));

        comments.Add(new Comment("Rakesh32323", "User1", "p4c1r0", null, "----some comment----", "post42002"));
        comments.Add(new Comment("seeni435214", "some replier1", "p4c1r1", "p4c1r0", "-----some reply-----", "post42002"));
        comments.Add(new Comment("seeni435214", "User1", "p4c1r2", "p4c1r1", "-----some reply-----", "post42002"));
        comments.Add(new Comment("seeni435214", "some replier1", "p4c1r3", "p4c1r3", "-----some reply-----", "post42002"));
        comments.Add(new Comment("seeni435214", "User1", "p4c1r4", "p4c1r3", "-----some reply-----", "post42002"));
        comments.Add(new Comment("balaji23232", "User2", "p4c2r0", null, "----some comment----", "post42002"));
        comments.Add(new Comment("shiva42424", "User3", "p4c3r0", null, "----some comment----", "post42002"));
        comments.Add(new Comment("seeni435214", "some replier1", "p4c3r1", "p4c3r0", "-----some reply-----", "post42002"));
        comments.Add(new Comment("seeni435214", "some replier2", "p4c3r2", "p4c3r1", "-----some reply-----", "post42002"));
        comments.Add(new Comment("Sanjei35756", "User4 ", "p4c3r1", null, "----some comment----", "post42002"));
        comments.Add(new Comment("seeni435214", "User5", "p4c4r0", null, "----some comment----", "post42002"));
        comments.Add(new Comment("seeni435214", "some replier1", "p4c4r1", "p4c4r0", "-----some reply-----", "post42002"));
        comments.Add(new Comment("Jiraya2231r46", "User6", "p4c5r0", null, "----some comment----", "post42002"));
        comments.Add(new Comment("shiva42424", "User7", "p4c7r0", null, "----some comment----", "post42002"));
        comments.Add(new Comment("Sanjei35756", "User8", "p4c8r1", null, "----some comment----", "post42002"));

        comments.Add(new Comment("User24355", "User32", "rac1r0", null, "----some comment----", "post12022"));
        comments.Add(new Comment("User24355", "some Replier1", "rac1r1", "rac1r0", "----some reply----", "post12022"));
        comments.Add(new Comment("User24355", "some Replier2", "rac1r2", "rac1r1", "----some reply----", "post12022"));
        comments.Add(new Comment("User24355", "User32", "rac1r3", "rac1r2", "----some comment----", "post12022"));
        comments.Add(new Comment("User24355", "some Replier2", "rac1r4", "rac1r3", "----some comment----", "post12022"));

        comments.Add(new Comment("User24355", "User64", "rac2r0", null, "----some comment----", "post12022"));
        comments.Add(new Comment("User24355", "some Replier2", "rac1r3", "rac2r0", "----some reply----", "post12022"));
        comments.Add(new Comment("User24355", "User64", "rac1r4", "rac1r3", "----some reply----", "post22022"));

        comments.Add(new Comment("User24355", "User12", "rac3r0", null, "----some comment----", "post22022"));
        comments.Add(new Comment("User24355", "User01", "rac3r0", null, "----some comment----", "post22022"));
        comments.Add(new Comment("Rakesh32323", "User1", "p4c1r0", null, "----some comment----", "post22022"));
        comments.Add(new Comment("seeni435214", "some replier1", "p4c1r1", "p4c1r0", "-----some reply-----", "post22022"));
        comments.Add(new Comment("seeni435214", "User1", "p4c1r2", "p4c1r1", "-----some reply-----", "post22022"));
        comments.Add(new Comment("seeni435214", "some replier1", "p4c1r3", "p4c1r3", "-----some reply-----", "post22022"));
        comments.Add(new Comment("seeni435214", "User1", "p4c1r4", "p4c1r3", "-----some reply-----", "post22022"));

        return comments;
    }
}