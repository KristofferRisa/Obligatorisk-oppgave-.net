using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Antiforgery.Internal;
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
        private ApplicationDbContext _db;
        private IHttpContextAccessor _httpContext;

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
                    int fallback = 0;

                    while (answers.Contains(questionNumber) && fallback <= numberOfQuestions)
                    {
                        fallback++;
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
        public ActionResult Step([Bind("QuestionNumber", "Alternative")]Answer answer)
        {
            if(ModelState.IsValid)
            {
                answer.UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                answer.Created = DateTime.Now;
                _db.Answers.Add(answer);
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

            //var correctAnswers = from a in _db.Answers.Where(x => x.UserId == userId)
            //    join q in _db.Question on a.QuestionNumber equals q.Number
            //    where (a.Alternative == q.Answer)
            //    select new {a.QuestionNumber, a.Alternative};

            //var numberOfCorretAnswers = correctAnswers.ToList().Count();
            //var allQuestion = _db.Answers.Count(x => x.UserId == userId);

            //decimal prosent = Convert.ToDecimal(numberOfCorretAnswers) / Convert.ToDecimal(allQuestion) * 100;
            //ViewData["prosent"] = prosent.ToString();
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