using Microsoft.AspNetCore.Components.Rendering;
using Newtonsoft.Json;
using RookieDriver.Models;
using System.Globalization;

namespace RookieDriver.JSON
{
    public class JsonReadWrite
    {
        public static string Filepath = "C:\\Users\\tejis\\source\\repos\\RookieDriver\\RookieDriver\\Data\\QuestionBank.json";

        public static string Userpath = "C:\\Users\\tejis\\source\\repos\\RookieDriver\\RookieDriver\\Data\\UserData.json";

        public static List<Question> ReadQuestions()
        {
            string jsonString = File.ReadAllText(Filepath);
            List<Question> questionFromJSON = JsonConvert.DeserializeObject<List<Question>>(jsonString);
            return questionFromJSON.ToList();
        }

        public static List<User> ReadUsers()
        {
            string jsonString = File.ReadAllText(Userpath);
            List<User> userFromJSON = JsonConvert.DeserializeObject<List<User>>(jsonString);
            return userFromJSON.ToList();
        }

        public static void WriteUsers(List<User> users)
        {
            string jsonString = JsonConvert.SerializeObject(users);
            File.WriteAllText(Userpath, jsonString);
        }
    }
}
