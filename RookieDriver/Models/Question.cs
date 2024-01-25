﻿namespace RookieDriver.Models
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
        public string Description { get; set; }

        public int CorrectAnswer { get; set; }

        public List<Test> ResultHistory { get; set; }
    }

    public class Test
    {
        public string Description { get; set; }

        public int CorrectAnswer { get; set; }

        public int UserId { get; set; }
    }
}
