using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trafikkal.web.Data;
using Trafikkal.web.Models;
using Trafikkal.web.Models.TestViewModels;

namespace Trafikkal.web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize]
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContext;
        private readonly string _userId;

        public TestController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _db = context;
            _httpContext = httpContextAccessor;
            _userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        /// <summary>
        /// GET: /Student/Test/Step
        /// </summary>
        public ActionResult Step()
        {
            if (_userId != null)
            {
                var answers = _db.Answers.Where(x => x.UserId == _userId).Select(x => x.QuestionNumber).Distinct().ToList();
                var numberOfQuestions = _db.Question.Select(x => x.Number).Distinct().Count();
                if (answers.Count >= 0 && answers.Count < numberOfQuestions)
                {
                    //next question
                    var random = new Random();
                    List<int> numbers = new List<int>();
                    for (int i = 1; i < numberOfQuestions; i++)
                    {
                        //TODO - add an list of numbers and loop through the array and pick questionsnumber,after selection remove it from the list
                        numbers.Add(i);
                    }

                    var questionNumber = random.Next(1, numberOfQuestions+1);
                    
                    while (answers.Contains(questionNumber))
                    {   
                        questionNumber = random.Next(1,numberOfQuestions+1);
                    }

                    var viewModel = new StepViewModel()
                    {
                        Question = _db.Question.FirstOrDefault(x => x.Number == questionNumber),
                        NumberOfQuestions = numberOfQuestions,
                        Answered = answers.Count+1
                    };

                    
                    return View(viewModel);
                }
            }
            //Calculate the result and save it to the database

            if (!UserScoreExists(_userId))
            {
                using (var con = (SqlConnection) _db.Database.GetDbConnection())
                {
                    decimal score = 0;
                    using (var cmd = new SqlCommand("EXEC dbo.GetScoreByUserId @UserId", con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);

                        con.Open();
                        score = (decimal) cmd.ExecuteScalar();
                    }
                    var userScore = new UserScore()
                    {
                        Points = score,
                        UserId = _userId,
                        QuizId = 1
                    };

                    //Saving the user score
                    _db.UserScores.Add(userScore);
                    _db.SaveChanges();
                }
            }

            return RedirectToAction("Result", "Test");
        }

        /// <summary>
        /// POST: /Student/Test/Step
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Step([Bind("QuestionNumber", "Alternative", "Alternative1", "Alternative2", "Alternative3", "Alternative4", "Alternative5")]AnswerViewModel answerViewmodel)
        {
            if(ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(answerViewmodel.Alternative))
                {
                    var answer = new Answer()
                    {
                        QuestionNumber = answerViewmodel.QuestionNumber,
                        Alternative = answerViewmodel.Alternative,
                        UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                        Created = DateTime.Now
                    };
                    _db.Answers.Add(answer);
                }
                else
                {
                    //Spørsmål er multiple choice - legger inn rad for hvert alternativ som er valgt
                    //dersom et alternativ ikke er valgt blir det null\blankt
                    if (!string.IsNullOrEmpty(answerViewmodel.Alternative1))
                    {
                        var answer = new Answer()
                        {
                            QuestionNumber = answerViewmodel.QuestionNumber,
                            Alternative = answerViewmodel.Alternative1,
                            UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                            Created = DateTime.Now
                        };
                        _db.Answers.Add(answer);
                    }
                    if (!string.IsNullOrEmpty(answerViewmodel.Alternative2))
                    {
                        var answer = new Answer()
                        {
                            QuestionNumber = answerViewmodel.QuestionNumber,
                            Alternative = answerViewmodel.Alternative2,
                            UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                            Created = DateTime.Now
                        };
                        _db.Answers.Add(answer);
                    }
                    if (!string.IsNullOrEmpty(answerViewmodel.Alternative3))
                    {
                        var answer = new Answer()
                        {
                            QuestionNumber = answerViewmodel.QuestionNumber,
                            Alternative = answerViewmodel.Alternative3,
                            UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                            Created = DateTime.Now
                        };
                        _db.Answers.Add(answer);
                    }
                    if (!string.IsNullOrEmpty(answerViewmodel.Alternative4))
                    {
                        var answer = new Answer()
                        {
                            QuestionNumber = answerViewmodel.QuestionNumber,
                            Alternative = answerViewmodel.Alternative4,
                            UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                            Created = DateTime.Now
                        };
                        _db.Answers.Add(answer);
                    }
                    if (!string.IsNullOrEmpty(answerViewmodel.Alternative5))
                    {
                        var answer = new Answer()
                        {
                            QuestionNumber = answerViewmodel.QuestionNumber,
                            Alternative = answerViewmodel.Alternative5,
                            UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                            Created = DateTime.Now
                        };
                        _db.Answers.Add(answer);
                    }
                }
                _db.SaveChanges();
            }
            return RedirectToAction("Step");
        }

        /// <summary>
        /// GET: /Student/Test/Result
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Result()
        {
            var viewModel = new ResultViewModel();
            if (UserScoreExists(_userId))
            {
                viewModel.UserScore = _db.UserScores.FirstOrDefault(x => x.UserId == _userId);
                viewModel.Quiz = _db.Quiz.FirstOrDefault(x => x.Id == viewModel.UserScore.QuizId);

                if (viewModel.Quiz.MinScoreToPass <= viewModel.UserScore.Points) 
                {
                    viewModel.Tekst = "Gratulerer du har bestått";
                    viewModel.Passed = true;
                }
                else
                {
                    viewModel.Tekst = "Du bestå ikke prøven!";
                    viewModel.Passed = false;
                }
            }
            else
            {
                //Fant ingen score!
                return RedirectToAction("Index", "Me");
            }
            return View(viewModel);
        }

        /// <summary>
        /// GET: /Student/Test/FullResult
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult FullResult()
        {
            var viewModel = new FullResultViewModel()
            {
                Questions = _db.Question.ToList(),
                Answers = _db.Answers.Where(x => x.UserId == _userId).ToList(),
                UserScore = _db.UserScores.FirstOrDefault(x => x.UserId == _userId)
            };
            return View(viewModel);
        }

        /// <summary>
        /// GET: /Student/Test/FullResult/133424-1231241241-411444
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/Student/Test/FullResult/{id:int}")]
        public ActionResult FullResult(int id)
        {
            var userId = _db.UserScores.FirstOrDefault(x => x.Id == id).UserId;
            var viewModel = new FullResultViewModel()
            {
                Questions = _db.Question.ToList(),
                Answers = _db.Answers.Where(x => x.UserId == userId).ToList(),
                UserScore = _db.UserScores.FirstOrDefault(x => x.UserId == userId),
                UserName = _db.Students.Any(x => x.UserId == userId) ? _db.Students.First(x => x.UserId == userId).Navn : userId
            };
            return View(viewModel);
        }

        /// <summary>
        /// GET: /Student/Test/Reset
        /// Method for re-setting the test for this user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Reset()
        {
            _db.Database.ExecuteSqlCommand($@"DELETE FROM Answers  WHERE userid = '{_userId}'");
            _db.Database.ExecuteSqlCommand($@"DELETE FROM UserScores WHERE UserId = '{_userId}'");
            _db.SaveChanges();

            return RedirectToAction("Index", "Me");
        }

        /// <summary>
        /// GET: /Student/Test/Reset/1
        /// A method for re-setting the test for a given user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/Student/Test/Reset/{id:int}")]
        public ActionResult Reset(int id)
        {
            var userId = _db.UserScores.First(x => x.Id == id).UserId;

            _db.Database.ExecuteSqlCommand($@"DELETE FROM Answers  WHERE userid = '{userId}'");
            _db.Database.ExecuteSqlCommand($@"DELETE FROM UserScores WHERE UserId = '{userId}'");
            _db.SaveChanges();

            return RedirectToAction("Index", "Scores", new { area="Admin"});
        }

        #region helpers
        /// <summary>
        /// Helper method for checking if user has saved her/his score for a test based on UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private bool UserScoreExists(string userId)
        {
            return _db.UserScores.Any(x => x.UserId == userId);
        }

        #endregion

    }
}