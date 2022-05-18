using FbConsoleApk.Controller;

namespace FbConsoleApk.View;

public class FbConsole
{
    public static void Main(string[] args)
    {
        Login.UserWelcomePage();
        UserController.RedirectToSignIn();
        Console.ReadKey();
    }
}






