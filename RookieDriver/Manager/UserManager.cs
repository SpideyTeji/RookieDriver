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

    // User save test result
}