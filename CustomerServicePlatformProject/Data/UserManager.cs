using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerServicePlatformProject.Models;
namespace CustomerServicePlatformProject.Data
{
    public  class UserManager
    {
        private static List<User> _usersList = UserDatabase();

        public List<User> UserList
        {
            get
            {
                return _usersList;
            }
        }

        public static List<User> UserDatabase()
        {
           var userList = new List<User>();
            for (int i = 101; i < 999; i++)
            {
                User user = new User();
                user.userId = i;
                userList.Add(user);
            }
            return userList;
        }
        internal static void IncrementIssueCount(int userId)
        {
            _usersList.SingleOrDefault(temp => temp.userId == userId).NoOfIssuesPosted++;
        }

        internal static void IncrementUpVotesGiven(int userId)
        {
            _usersList.SingleOrDefault(temp => temp.userId == userId).NoOfUpvotesGiven++;
        }

        internal static void IncrementDownVotesGiven(int userId)
        {
            _usersList.SingleOrDefault(temp => temp.userId == userId).NoOfDownvotesGiven++;
        }

        internal static void IncrementSolutionCount(int userId)
        {
            _usersList.SingleOrDefault(temp => temp.userId == userId).NoOfSolutionsGiven++;
        }

        internal static void IncrementCommentCount(int userId)
        {
            _usersList.SingleOrDefault(temp => temp.userId == userId).NoOfCommentsPosted++;
        }

        internal static bool IsValidUser(int id)
        {
            return _usersList.Exists(temp => temp.userId == id);
        }

        internal static User FetchUserObj(int id)
        {
            return _usersList.SingleOrDefault(temp => temp.userId == id);
        }
    }
}
