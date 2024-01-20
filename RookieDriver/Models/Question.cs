using System.Reflection.Metadata.Ecma335;

namespace RookieDriver.Models
{
    public class Question
    {
        public string Description { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAnswer { get; set; }
        public string UserAnswer { get; set; }
       

        public bool IsAnswerCorrect (string UserAnswer)
        { 
            return CorrectAnswer == UserAnswer;
        }


    }
}
