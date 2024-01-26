using Microsoft.AspNetCore.Components.Rendering;
using Newtonsoft.Json;
using RookieDriver.Models;
using System.Globalization;

namespace RookieDriver.JSON
{
    public class JsonReadWrite
    {
        public string Filepath = "C:\\Users\\tejis\\source\\repos\\RookieDriver\\RookieDriver\\Data\\QuestionBank.json";

        public string Userpath = "C:\\Users\\tejis\\source\\repos\\RookieDriver\\RookieDriver\\Data\\UserData.json";

        public List<Question> ReadQuestions()
        {
            var jsonString = File.ReadAllText(Filepath);
            var questionFromJSON = JsonConvert.DeserializeObject<List<Question>>(jsonString);
            return questionFromJSON.ToList();
        }

        public List<User> ReadUsers()
        {
            var jsonString = File.ReadAllText(Userpath);
            var userFromJSON = JsonConvert.DeserializeObject<List<User>>(jsonString);
            return userFromJSON.ToList();
        }

        public void WriteUsers(List<User> users)
        {

        }
    }
}
