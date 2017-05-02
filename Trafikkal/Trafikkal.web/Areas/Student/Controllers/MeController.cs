using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trafikkal.web.Data;
using Trafikkal.web.Models;

namespace Trafikkal.web.Areas.Student.Controllers
{
    [Area("Student")]
    public class MeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContext;

        public MeController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _db = context;
            _httpContext = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Oppdater()
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
        [ValidateAntiForgeryToken]
        public IActionResult Oppdater([Bind("navn,telefon")] Models.Student student)
        {
            //TODO: Denne fungerer ikke!
            student.UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
            }
            return View();
        }
        
    }
}