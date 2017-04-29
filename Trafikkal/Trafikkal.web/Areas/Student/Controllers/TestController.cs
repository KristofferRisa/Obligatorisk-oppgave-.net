using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trafikkal.web.Data;
using Trafikkal.web.Models;

namespace Trafikkal.web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize]
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContext;

        public TestController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _db = context;
            _httpContext = httpContextAccessor;
        }

        /// <summary>
        /// GET: /Student/Test/Step
        /// </summary>
        public ActionResult Step()
        {
            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId != null)
            {
                var answers = _db.Answers.Where(x => x.UserId == userId).Select(x => x.QuestionNumber).ToList();
                var numberOfQuestions = _db.Question.Count();
                if (answers.Count >= 0 && answers.Count < numberOfQuestions+1)
                {
                    //next question
                    var random = new Random();

                    var questionNumber = random.Next(1, numberOfQuestions);
                    
                    while (answers.Contains(questionNumber))
                    {   
                        questionNumber = random.Next(1,numberOfQuestions);
                    }

                    var question = _db.Question.FirstOrDefault(x => x.Number == questionNumber);
                    return View(question);
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
                    if (string.IsNullOrEmpty(answerViewmodel.Alternative1))
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
                    if (string.IsNullOrEmpty(answerViewmodel.Alternative2))
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
                    if (string.IsNullOrEmpty(answerViewmodel.Alternative3))
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
                    if (string.IsNullOrEmpty(answerViewmodel.Alternative4))
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
                    if (string.IsNullOrEmpty(answerViewmodel.Alternative5))
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
            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var answers = _db.Answers.Where(x => x.UserId == userId).ToList();
            var questions = _db.Question.ToList();
            int numberOfCorrectAnswers = 0;
            
            foreach (var answer in answers)
            {
                if (questions.Exists(x => x.Number == answer.QuestionNumber && x.IsAlternative1Correct))
                {
                    numberOfCorrectAnswers++;
                }
                      
                if (questions.Exists(x => x.Number == answer.QuestionNumber && x.IsAlternative2Correct))
                {
                    numberOfCorrectAnswers++;
                }
                if (questions.Exists(x => x.Number == answer.QuestionNumber && x.IsAlternative3Correct))
                {
                    numberOfCorrectAnswers++;
                }
                if (questions.Exists(x => x.Number == answer.QuestionNumber && x.IsAlternative4Correct))
                {
                    numberOfCorrectAnswers++;

                }
                if (questions.Exists(x => x.Number == answer.QuestionNumber && x.IsAlternative5Correct))
                {
                    numberOfCorrectAnswers++;
                }
                        
            }

            decimal prosent = Convert.ToDecimal(numberOfCorrectAnswers) / Convert.ToDecimal(questions.Count) * 100;
            ViewData["prosent"] = prosent.ToString();
            if (_db.Quiz.FirstOrDefault().MinScoreToPass <= prosent)
            {
                ViewData["bestatt_tekst"] = "Gratulerer du har bestått";
                ViewData["bestatt"] = true;
            }else
            {
                ViewData["bestatt_tekst"] = "Du bestå ikke prøven!";
                ViewData["bestatt"] = false;
            }
            
            return View();
        }


        public ActionResult Reset()
        {
            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _db.Database.ExecuteSqlCommand($@"delete from Answers  where userid = '{userId}'");
            _db.SaveChanges();

            return RedirectToAction("Index", "Me");
        }
    }
}