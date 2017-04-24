using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trafikkal.web.Data;

namespace Trafikkal.web.Areas.Student.Controllers
{
    [Area("Student")]
    public class MeController : Controller
    {
        private ApplicationDbContext _db;

        public MeController(ApplicationDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
    }
}