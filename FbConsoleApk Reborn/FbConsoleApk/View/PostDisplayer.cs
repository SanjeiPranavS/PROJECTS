using FbConsoleApk.Controller;
using FbConsoleApk.Model;

namespace FbConsoleApk.View;

public class PostDisplayer
{
    public static void PrintPost(Post post)
    {
        if (!string.IsNullOrEmpty(post.PostDescription)) Console.Clear();
        Console.WriteLine($"{post.UserName}");
        Console.WriteLine();
        Console.WriteLine($"{post.PostDescription}");
        Console.WriteLine();
        Console.WriteLine("=========================================");
        Console.Write("|");
        for (var i = 0; i < 19 - post.Image.Length / 2; i++) Console.Write(" ");
        Console.Write(post.Image);
        for (var i = 0; i < 19 - post.Image.Length / 2; i++) Console.Write(" ");
        Console.WriteLine("|");
        Console.Write("|");
        for (var i = 0; i < 39; i++) Console.Write(" ");
        Console.WriteLine("|");
        Console.WriteLine("=========================================");
    }

    internal static void PrintProfile(User client, int postCount)
    {
        Console.Clear();
        Console.WriteLine("PROFILE");
        PrintPost(new Post
        {
            Image = $"{client.UserName}.jpg"
        });
        Console.WriteLine($"{client.UserName}");
        Console.WriteLine();
        Console.WriteLine($"{client.Gender}");
        Console.WriteLine();
        Console.WriteLine($"{client.DateOfBirth:D}");
        Console.WriteLine();
        Console.WriteLine($"No of posts :{postCount}");
        Console.ReadKey();
    }

    //public static void PrintProfile(User client)
    //{
    //    Console.Clear();
    //    Console.WriteLine("PROFILE");
    //    PrintPost(new Post
    //    {
    //        Image = $"{client.UserName}.jpg"
    //    });
    //    Console.WriteLine($"{client.UserName}");
    //    Console.WriteLine();
    //    Console.WriteLine($"{client.Gender}");
    //    Console.WriteLine();
    //    Console.WriteLine($"{client.DateOfBirth:D}");
    //    Console.WriteLine();
    //    Console.WriteLine($"No of posts :{client.NoOfPosts}");
    //    Console.ReadKey();
    //}

    public  static Post GetPostDetails(string userUniqueId, string userName)
    {
        var newPost = new Post();
        newPost.UserUniqueId = userUniqueId;
        newPost.UserName     = userName;
        newPost.PostUniqueId = newPost.GetUniquePostId();
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Post Discription");
        Console.Write("(Express your thoughts about your post)......");
        newPost.PostDescription = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Upload your Image");
        Console.Write("(Explore the world with .jpg)......");
        var image = Console.ReadLine();
        if (string.IsNullOrEmpty(image))
        {
            Console.WriteLine("please upload image properly.......");
            Console.ReadKey();
            return GetPostDetails(userUniqueId,userName);
            
        }

        newPost.Image = image + ".jpg";
        Console.WriteLine();
        Console.WriteLine("your post is added successfully :)");
        Console.ReadKey();
        return newPost;
    }

    public static int PostAction()
    {
        Console.WriteLine();
        Console.WriteLine("Add Post - 1");
        Console.WriteLine("View Post - 2");
        Console.WriteLine();
        try
        {
            int userChoice = Convert.ToInt16(Console.ReadLine());
            if (!Validation.ValidUserInput(userChoice, 1, 2))
            {
                throw new FormatException();
            }

            return userChoice;
        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("please Enter choice between ( 1, 2 )");
            return PostAction();
        }
    }

    //public static void GetPostDetails(Post newPost)
    //{
    //    Console.Clear();
    //    Console.WriteLine();
    //    Console.WriteLine("Post Discription");
    //    Console.Write("(Express your thoughts about your post)......");
    //    newPost.PostDescription = Console.ReadLine();
    //    Console.WriteLine();
    //    Console.WriteLine("Upload your Image");
    //    Console.Write("(Explore the world with .jpg)......");
    //    var image = Console.ReadLine();
    //    if (image == null)
    //    {
    //        Console.WriteLine("please upload image properly.......");
    //        GetPostDetails(newPost);
    //        return;
    //    }

    //    newPost.Image = image + ".jpg";
    //    Console.WriteLine();
    //    Console.WriteLine("your post is added successfully :)");
    //    Console.ReadKey();
    //}

    public static int AfterAddPostAction()
    {
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("go to login page - 1");
        Console.WriteLine("go to profile page -2");
        Console.WriteLine("Add likes  -3");
        Console.WriteLine();
        try
        {
            var choice = Convert.ToInt32(Console.ReadLine());
            if (!Validation.ValidUserInput(choice, 1, 3))
            { throw new FormatException();}
            return choice;
        }
        catch (FormatException)
        {
            Console.WriteLine("Please Enter the numbers between ( 1 , 2 , 3 )");
            Console.ReadKey();
            return AfterAddPostAction();
        }
    }

    public static int ViewPostUserAction()
    {
        Console.WriteLine();
        Console.WriteLine("go to login page  - 1");
        Console.WriteLine("Next post         - 2");
        Console.WriteLine("View like details - 3");
        Console.WriteLine("View Comments     - 4");
        Console.WriteLine("go to Profile     - 5");
        Console.WriteLine("Add Like to post  - 6");
        try
        {
            Console.WriteLine();
            var choice = Convert.ToInt32(Console.ReadLine());
            if (!Validation.ValidUserInput(choice, 1, 6))
            { throw new FormatException();}
            return choice;
        }
        catch (FormatException)
        {
            return ViewPostUserAction();
        }
    }
}