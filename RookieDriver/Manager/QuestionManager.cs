using RookieDriver.JSON;
using RookieDriver.Models;

namespace RookieDriver.Manager
{
    public class QuestionManager
    {
#if DEBUG
        private int NO_OF_QUESTION_FOR_TEST = 5;
#else
        private int NO_OF_QUESTION_FOR_TEST = 45;
#endif
        private List<Question> AllQuestionList = new List<Question>();

        private int PassScore = 41;

        private Random random = Random.Shared; // Random number generator

        public QuestionManager() 
        {
            AllQuestionList = JsonReadWrite.ReadQuestions(); // Read all question from QuestionBank.json. && Store it in a variable.
            PassScore = (int)Math.Round(0.9*NO_OF_QUESTION_FOR_TEST, MidpointRounding.AwayFromZero);
        }

        public int TotalQuestionCount() => NO_OF_QUESTION_FOR_TEST;

        public int PassScoreCount() => PassScore;

        public List<Question> GiveAllQuestions() => AllQuestionList.OrderBy(x => random.Next()).ToList();

        public List<Question> GiveRandomQuestions()
        {
            List<Question> questionList = new List<Question>(); // Create a list for user to take test

            List<int> positionList = new List<int>(); // Track the positions generated so its always unique Qs.

            for (int i = 0; i < NO_OF_QUESTION_FOR_TEST; i++) // Loop 45 times to get 45 questions.
            {
                var position = random.Next(AllQuestionList.Count - 1); // Generate a random position with max value of all questions count

                if (positionList.Contains(position)) // Check if the position is unique
                {
                    i--;
                    continue; // Is found you continue;
                }

                var randomQuestion = AllQuestionList[position]; // Get the Question from the position

                randomQuestion.Options = randomQuestion.Options.OrderBy(x => random.Next()).ToList(); // Shuffle the options
                
                positionList.Add(position); // Add to known positions
                questionList.Add(randomQuestion); // Add question to be retuned
            }

            return questionList;
        }
    }
}
