using RookieDriver.CSV;
using RookieDriver.JSON;
using RookieDriver.Models;

namespace RookieDriver.Manager
{
    public class QuestionManager
    {
        private int NO_OF_QUESTION_FOR_TEST = 45;

        public List<Question> GiveMeTestQuestion()
        {
            List<Question> allQuestions = JsonReadWrite.ReadQuestions(); // Read all question from QuestionBank.json. && Store it in a variable.

            List<Question> questionList = new List<Question>(); // Create a list for user to take test

            List<int> positionList = new List<int>(); // Track the positions generated so its always unique Qs.

            Random random = new Random(); // Random number generator

            for (int i = 0; i < NO_OF_QUESTION_FOR_TEST; i++) // Loop 45 times to get 45 questions.
            {
                var position = random.Next(allQuestions.Count - 1); // Generate a random position with max value of all questions count

                if (positionList.Contains(position)) // Check if the position is unique
                {
                    continue; // Is found you continue;
                }

                var randomQuestion = allQuestions[position]; // Get the Question from the position

                randomQuestion.Options.OrderBy(x => random.Next()); // Shuffle the options

                positionList.Add(position); // Add to known positions
                questionList.Add(randomQuestion); // Add question to be retuned
            }

            return questionList;
        }
    }
}
