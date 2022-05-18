using FbConsoleApk.Controller;
using FbConsoleApk.Model;

namespace FbConsoleApk.View;

public class CommentDisplayer
{
    public static void PrintPostComment(Comment comment)
    {
        Console.WriteLine($"{comment.UserName}:   {comment.PostComment} ");
        PrintCommentReply(comment.UniqueCommentId, comment.UserName, comment.PostUniqueId);
        Console.WriteLine();
    }

    private static void PrintCommentReply(string parent, string cmtrName, string postId)
    {
        var comment = CommentController.GetChildComment(postId, parent);
        if (comment == null)
        {
            return;
        }
        Console.Write("      ");
        Console.WriteLine($"{comment.UserName}: @{cmtrName}  {comment.PostComment}");
        PrintCommentReply(comment.UniqueCommentId, comment.UserName, comment.PostUniqueId);
    }

    public static int AfterCmtsUserChoice()
    {
        Console.WriteLine();
        Console.WriteLine("go to login page  - 1");
        Console.WriteLine("go to Profile     - 2");
        Console.WriteLine("Next post          -3");
        Console.WriteLine("view likes details -4");
        Console.WriteLine("close command      -5");
        Console.WriteLine();
        try
        {
            var choice = Convert.ToInt32(Console.ReadLine());
            if (!Validation.ValidUserInput(choice, 1, 5))
            {
                throw new FormatException();
            }

            return choice;
        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("please Enter values between(1,2,3,4,5)");
            return AfterCmtsUserChoice();
        }
    }
}