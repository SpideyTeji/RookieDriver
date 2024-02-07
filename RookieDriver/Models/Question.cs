

using Newtonsoft.Json;

namespace RookieDriver.Models
{
    public class Question
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public int CorrectAnswer { get; set; }

        public int UserAnswer { get; set; }

        public List<Option> Options { get; set; }

        public string FileName { get; set; }

        [JsonIgnore]
        public string ImageFilePath => $"images/{FileName}";
    }

    public class Option
    {
        public string Description { get; set; }

        public int Id { get; set; }
        public int QuestionId { get; set; }
    }

    public class User
    {
        public User(string email, string username, string password)
        {
            this.Email = email;
            this.Username = username;
            this.Password  = password;
            this.ResultHistory = new List<Test>();
        }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<Test> ResultHistory { get; set; }
    }

    public class Test
    {
        [JsonIgnore]
        public List<Question> QuestionList { get; set; }

        public int FinalScore { get; set; }

        public int TotalScore { get; set; }

        public int PassScore { get; set; }

        public DateTime TestDate { get; set; }

        public string Username { get; set; }
    }
}
