namespace RookieDriver.Models
{
    public class Question
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public int CorrectAnswer { get; set; }

        public int UserAnswer { get; set; }

        public List<Option> Options { get; set; }

    }

    public class Option
    {
        public string Description { get; set; }

        public int Id { get; set; }
        public int QuestionId { get; set; }
    }

    public class User
    {
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<Test> ResultHistory { get; set; }
    }

    public class Test
    {
        public List<Question> QuestionList { get; set; }

        public int FinalScore { get; set; }

        public string Username { get; set; }
    }
}
