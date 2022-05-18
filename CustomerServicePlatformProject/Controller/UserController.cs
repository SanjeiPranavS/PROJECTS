using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Data;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Controller
{
    public class UserController
    {
        static UserManager userManager=new UserManager();
        public static bool IsValidUser(int id)
        {
            return UserManager.IsValidUser(id);
        }
        public static User FetchUserObj(int id)
        {
            return UserManager.FetchUserObj(id);
        }
        public static List<User> GetList()
        {
            return userManager.UserList;
        }
    }
}
