using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: /Quiz/Step/1
        /// </summary>
        public ActionResult Step()
        {
            //var usedQuestion = new List<int>();
            //ViewBag["question"] = usedQuestion;
            //var cookie = Request.Cookies["q"];
            //if (cookie != null && Convert.ToInt32(cookie) > id)
            //{
            //    return RedirectToAction("Step", new { id = Convert.ToInt32(cookie) });
            //}

            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId != null)
            {
                var answers = _db.Answers.Where(x => x.UserId == userId).Select(x => x.QuestionNumber).ToList();
                if (answers.Count >= 0 || answers.Count < 21)
                {
                    //next question
                    var random = new Random();

                    var questionNumber = random.Next(1, 20);
                    
                    while (answers.Contains(questionNumber))
                    {
                        questionNumber = random.Next();
                    }

                    var question = _db.Question.FirstOrDefault(x => x.Number == questionNumber);
                    return View(question);
                }
            }
            return RedirectToAction("Index", "Home");
        }

    }
}