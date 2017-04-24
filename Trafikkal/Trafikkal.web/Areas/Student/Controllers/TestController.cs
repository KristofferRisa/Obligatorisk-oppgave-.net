using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trafikkal.web.Areas.Student.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: /Quiz/Step/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Step(int? id)
        {
            var cookie = Request.Cookies.Where(x => x.Key == "q").Select(x => x.Value);
            if (cookie != null && Convert.ToInt32(cookie) > id)
            {
                return RedirectToAction("Step", new { id = Convert.ToInt32(cookie) });
            }
            if (id != null)
            {
                //Checking cookie for Groupname value
                var httpCookie = Request.Cookies.Where(x => x.Key == "team").Select(x => x.Value);
                if (httpCookie != null)
                {
                    //cookie = httpCookie.Value;
                    ////Getting the question fromo the database
                    //var q = _db.Quizzes.SingleOrDefault(x => x.Number == question && x.Active);

                    //Response.Cookies["q"].Value = (question + 1).ToString();
                    //Response.Cookies["q"].Expires = DateTime.Now.AddDays(1);

                    //if (q == null)
                    //{
                    //    return View("Ferdig");
                    //}
                    //return cookie != null ? View(q) : View("Error");

                    return View();
                }

            }
            return View("Error");
        }

    }
}