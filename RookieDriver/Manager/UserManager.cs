using RookieDriver.JSON;
using RookieDriver.Models;

namespace RookieDriver.Manager;

public class UserManager
{
    // Member
    private List<User> users; // All users

    public UserManager()
    {
        users = JsonReadWrite.ReadUsers(); // Read all json
    }

    // User login - Success/Failure (bool) 
    public bool UserLogin(string enteredUsername, string enteredPassword)
    {
        foreach (User user in users)
        {
            if (user.Username == enteredUsername && user.Password == enteredPassword)
            {
                return true;
            }
        }

        return false;
    }

    public bool ValidateEmail(string email)
    {
        foreach (User user in users)
        {
            if (user.Email == email)
            {
                return false;
            }
        }

        return true;
    }

    // Register User - Success/Failure (bool)
    public bool UserRegister(string email, string username, string password)
    {
        foreach (User user in users)
        {
            if(user.Username == username)
            {
                return false;
            }
        }

        User newUser = new User(email, username, password);
        users.Add(newUser);

        JsonReadWrite.WriteUsers(users);

        return true;
    }

    // Get user by username
    public User GetUser(string username) 
    {
        foreach (User user in users)
        {
            if (user.Username == username)
            {
                return user;
            }
        }

        return null;
    }

    public User NewUser(string email, string username,string password) 
    {
        var newUser = new User(email, username,password);
        users.Add(newUser);

        JsonReadWrite.WriteUsers(users);

        return newUser;
    }

    // User save test result
    public void SaveTest(Test testResult)
    {
        var user = GetUser(testResult.Username);
        user.ResultHistory.Add(testResult);

        JsonReadWrite.WriteUsers(users);
    }
}