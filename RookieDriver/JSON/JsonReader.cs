using Microsoft.AspNetCore.Components.Rendering;
using Newtonsoft.Json;
using RookieDriver.Models;

namespace RookieDriver.JSON
{
    public class JsonReader
    {
        public string Filepath = "C:\\Users\\tejis\\source\\repos\\RookieDriver\\RookieDriver\\Data\\QuestionBank.json";

        public List<Question> ReadQuestions()
        {
            var jsonString = File.ReadAllText(Filepath);
            var questionFromJSON = JsonConvert.DeserializeObject<List<Question>>(jsonString);
            return questionFromJSON.ToList();
        }
    }
}
