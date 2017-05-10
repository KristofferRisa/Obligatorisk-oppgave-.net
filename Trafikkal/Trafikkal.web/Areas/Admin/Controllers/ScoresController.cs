using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trafikkal.web.Data;
using Trafikkal.web.Models.ScoresViewModels;

namespace Trafikkal.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ScoresController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContext;
        private readonly string _userId;

        public ScoresController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _db = context;
            _httpContext = httpContextAccessor;
            _userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public IActionResult Index()
        {
            var viewModel = new ScoresViewModel
            {
                UserScores = _db.UserScores.ToList(),
                Quizzes = _db.Quiz.ToList(),
                Students = _db.Students.ToList()
            };
            return View(viewModel);
        }
    }
}