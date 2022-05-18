namespace FbConsoleApk.Model;

public class User
{
    public string UniqueId { get; set; }
    public string UserName { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
   

    public User(string uniqueId, string userName, int gender, DateTime dob)
    {
        UserName = userName;
        UniqueId = uniqueId;
        Gender = (Gender) gender;
        DateOfBirth = dob;
    }

    public User()
    {

    }
    
}

public enum Gender
{
    Male,
    Female,
    NotToPrefer
}