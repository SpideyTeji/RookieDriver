using Microsoft.AspNetCore.Components.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RookieDriver.Models;
using System.Globalization;

namespace RookieDriver.JSON
{
    public class JsonReadWrite
    {
        // File path for Question data.
        public static string Filepath = $"{Directory.GetCurrentDirectory()}\\Data\\QuestionBank.json";

        // File path for User data.
        public static string Userpath = $"{Directory.GetCurrentDirectory()}\\Data\\UserData.json";

        // Reading all the questions from Question data file.
        public static List<Question> ReadQuestions()
        { 
            string jsonString = File.ReadAllText(Filepath);
            List<Question> questionFromJSON = JsonConvert.DeserializeObject<List<Question>>(jsonString);
            return questionFromJSON.ToList();
        }

        // Reading all the users from Users data file.
        public static List<User> ReadUsers()
        {
            string jsonString = File.ReadAllText(Userpath);

            IsoDateTimeConverter isoDateTimeConverter = new IsoDateTimeConverter();
            isoDateTimeConverter.DateTimeFormat = "dd/MM/yyyy hh:mm tt";

            List<User> userFromJSON = JsonConvert.DeserializeObject<List<User>>(jsonString, isoDateTimeConverter);
            return userFromJSON.ToList();
        }

        // Writing user info to User data file.
        public static void WriteUsers(List<User> users)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatString = "dd/MM/yyyy hh:mm tt"
            };

            string jsonString = JsonConvert.SerializeObject(users, settings);
            File.WriteAllText(Userpath, jsonString);
        }
    }
}
