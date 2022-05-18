using FbConsoleApk.Model;

namespace FbConsoleApk.App_data.Repository;

internal class UserDataHandler
{
    private static  List<User> _users = Database.GetUsersList();


    public static User RetriveUserData(string uniqueUserId)
    {
        return _users.FirstOrDefault(usr => usr.UniqueId == uniqueUserId);
        
    }

    public static bool UserValidation(string uniqueUserId)
    {
        return _users.Exists(usr => usr.UniqueId == uniqueUserId);
    }

   
}