using FbConsoleApk.App_data.Repository;
using FbConsoleApk.Model;
using FbConsoleApk.View;

namespace FbConsoleApk.Controller;

public class UserController
{
    public static void RedirectToSignIn()
    {
        var userUniqueId = Login.UserWelcomePage();


        if (UserDataHandler.UserValidation(userUniqueId))
        {
            RedirectToProfile(userUniqueId);
        }
        else
        {
            RedirectToSignIn();
        }
    }

    public static void RedirectToProfile(string userUniqueId)
    {
        var client = UserDataHandler.RetriveUserData(userUniqueId);
        
        PostDisplayer.PrintProfile(client,PostDataHandler.GetNoOfPostCount(userUniqueId));
        switch (PostDisplayer.PostAction())
        {
            case 1:
                PostController.UploadNewPost(client.UniqueId,client.UserName);
                return;
            case 2:
                PostController.PeerUserPost(client);
                return;
        }
    }
}