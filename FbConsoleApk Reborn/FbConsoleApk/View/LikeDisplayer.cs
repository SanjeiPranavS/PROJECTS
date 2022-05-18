using FbConsoleApk.Controller;
using FbConsoleApk.Model;

namespace FbConsoleApk.View;

public class LikeDisplayer
{
   
    public static void PrintPostLikes(IEnumerable<LikesMapper> likes)
    {
        foreach (var like in likes) Console.WriteLine(like);

        Console.ReadKey();
    }

    public static int AfterLikesUserChoice()
    {
        Console.WriteLine();
        Console.WriteLine("go to login page - 1");
        Console.WriteLine("go to next Post -2");
        Console.WriteLine("View Comments - 3");
        Console.WriteLine("go to profile -4");
        Console.WriteLine("Close likes - 5");
        try
        {
            var choice = Convert.ToInt32(Console.ReadLine());
            if (!Validation.ValidUserInput(choice, 1, 5))
                throw new FormatException();
            return choice;
        }
        catch (FormatException)
        {
            Console.WriteLine("please enter correct choice(1,2,3,4)");
            Console.ReadKey();
            return AfterLikesUserChoice();
        }
    }

    public static void PrintLikeCmtCount(int likesCount, int commentsCount)
    {
        Console.WriteLine($"NO OF likes :{likesCount}");
        Console.WriteLine($"NO OF Comment :{commentsCount}");
    }


    internal static int GetUserReaction()
    {
        Console.WriteLine("Please Enter submit your reaction :");
        Console.WriteLine("Like - 1\nHeart -2\nLaugh -3\nWow -4\nSad -5\nAngry -6");
        try
        {
            var choice = Convert.ToInt16(Console.ReadLine());
            if (!Validation.ValidUserInput(choice, 1, 6))
            {
                throw new FormatException();
            }

            return choice;
            
        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("please choice valid Reaction"); 
             return GetUserReaction();
        }
    }

    public static int AlreadyLikeExist()
    {
        Console.WriteLine();
        Console.WriteLine("You Already reacted to this post");
        Console.WriteLine("go to profile - 1");
        Console.WriteLine("go to Login page -2");
        try
        {
            var choice = Convert.ToInt16(Console.ReadLine());
            if (!Validation.ValidUserInput(choice, 1, 2))
            {
                throw new FormatException();
            }

            return choice;
        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("please Enter valid Choice(1 , 2)");
            return AlreadyLikeExist();
        }
        
    }
}