using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trafikkal.web.Data;
using Trafikkal.web.Models;
using Trafikkal.web.Models.MeViewModels;


namespace Trafikkal.web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize]
    public class MeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContext;
        private readonly string _userId;

        public MeController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _db = context;
            _httpContext = httpContextAccessor;
            _userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        }

        public IActionResult Index()
        {
            var meViewModel = new MeViewModel();
            if (_db.Students.Any(x => x.UserId == _userId))
            {
                meViewModel.Student = _db.Students.FirstOrDefault(x => x.UserId == _userId);
            }

            return View(meViewModel);
        }

        [HttpGet]
        public ActionResult Oppdater()
        {
            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = new Models.Student();
            if (_db.Students.Any(x => x.UserId == userId))
            {
                user = _db.Students.FirstOrDefault(x => x.UserId == userId);
            }
            return View(user);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Oppdater([Bind("Navn,Telefon,Adresse")] Models.Student student)
        {
            if (ModelState.IsValid)
            {
                if (_db.Students.Any(x => x.UserId == _userId))
                {
                    //oppdater eksisterende data i databasen
                    var studentOld = _db.Students.FirstOrDefault(x => x.UserId == _userId);
                    studentOld.Navn = student.Navn;
                    studentOld.Adresse = student.Adresse;
                    studentOld.Telefon = student.Telefon;
                    _db.Students.Update(studentOld);
                }
                else
                {
                    //Brukeren har ikke fylt inn informasjon før
                    student.UserId = _userId;
                    _db.Students.Add(student);
                }
                    
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}