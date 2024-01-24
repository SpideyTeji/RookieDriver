namespace RookieDriver.Models
{
    public class Question
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public int CorrectAnswer { get; set; }

        public List<Option> Options { get; set; }

    }

    public class Option
    {
        public string Description { get; set; }

        public int Id { get; set; }
        public int QuestionId { get; set; }
    }
}
