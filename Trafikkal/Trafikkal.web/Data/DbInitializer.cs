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

            // Look for any students.
            if (context.Question.Any())
            {
                return;   // DB has been seeded
            }

            var questions = new List<Question>()
            {
                new Question()
                {
                    Number = 1,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 2,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 3,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 4,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 5,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 6,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 7,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 8,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 9,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 10,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 11,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 12,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 13,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 14,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 15,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 16,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 17,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 18,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 19,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
                },
                new Question()
                {
                    Number = 20,
                    Text = "Hva er ",
                    Alternative1 = "1",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    Answer = "4",
                    Active = true,
                    Created = DateTime.Now
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