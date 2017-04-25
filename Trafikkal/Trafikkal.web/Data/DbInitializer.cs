using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trafikkal.web.Models;

namespace Trafikkal.web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Quiz.Any())
            {
                var quiz = new Quiz()
                {
                    Id = 1,
                    Name = "Main",
                    MinScoreToPass = 70
                };

                context.Quiz.Add(quiz);
                context.SaveChanges();
            }

            // Look for any question.
            if (context.Question.Any())
            {
                return;   // DB has been seeded
            }

            var questions = new List<Question>()
            {
                new Question()
                {
                    Number = 1,
                    Text = "Hva er 1 +1 ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = true,
                   IsAlternative1Correct = false,
                   IsAlternative2Correct = false,
                   IsAlternative3Correct = true,
                   IsAlternative4Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 2,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 3,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 4,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 5,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 6,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 7,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 8,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 9,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 10,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                }
            };

            foreach (var question in questions)
            {
                context.Question.Add(question);
            }

            context.SaveChanges();
        }
    }
}