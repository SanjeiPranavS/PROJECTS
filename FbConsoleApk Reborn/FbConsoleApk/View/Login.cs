namespace FbConsoleApk.View;

public class Login
{
    public static string UserWelcomePage()
    {
        Console.Clear();
        Console.Write("                                            ");
        Console.WriteLine("//WELCOME TO WeConnect//");
        Console.WriteLine();
        Console.Write("                           ");
        Console.WriteLine("ENGAGE ,ENLIGHTEN, ENCOURAGE and ESPECIALLY ...... JUST BE YOURSELF :)");
        Console.WriteLine();
        Console.WriteLine("Login as...");
        Console.Write("                  ");
        var userName = Console.ReadLine().Trim();
        if (string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("please enter in correct format");
            Console.ReadKey();
            return UserWelcomePage();
        }

        return userName;
    }
}