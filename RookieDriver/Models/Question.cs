using CsvHelper.Configuration.Attributes;

namespace RookieDriver.Models
{
    public class Question
    {
        [Index(0)]
        public string Description { get; set; }
        [Index(1)]
        public string OptionA { get; set; }
        [Index(2)]
        public string OptionB { get; set; }
        [Index(3)]
        public string OptionC { get; set; }
        [Index(4)]
        public string CorrectAnswer { get; set; }

        [Ignore]
        public string UserAnswer { get; set; }
       

        public bool IsAnswerCorrect (string UserAnswer)
        { 
            return CorrectAnswer == UserAnswer;
        }


    }
}
