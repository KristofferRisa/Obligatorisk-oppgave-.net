using Microsoft.AspNetCore.Mvc;

namespace Trafikkal.web.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Home for students, a page that displays statues on tests and other stuff
            return View();
        }
    }
}