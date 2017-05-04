using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trafikkal.web.Data;
using Trafikkal.web.Models;
using Trafikkal.web.Models.TestViewModels;

namespace Trafikkal.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Admin/Questions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Question.ToListAsync());
        }

        // GET: Admin/Questions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Question
                .SingleOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }
            var viewModel = new QuestionViewModel()
            {
                Question = question,
                Quizzes = await _context.Quiz.ToListAsync()
            };
            return View(viewModel);
        }

        // GET: Admin/Questions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizId,Number,Text,Img,Video,Alternative1,Alternative2,Alternative3,Alternative4,Alternative5,IsAlternative1Correct,IsAlternative2Correct,IsAlternative3Correct,IsAlternative4Correct,IsAlternative5Correct,IsMultipleChoice,Active,Created")] Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            var viewModel = new QuestionViewModel()
            {
                Question = question,
                Quizzes = await _context.Quiz.ToListAsync()
            };
            return View(viewModel);
        }

        // GET: Admin/Questions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            
            var question = await _context.Question.SingleOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }
 
            var viewModel = new QuestionViewModel()
            {
                Question = question,
                Quizzes = await _context.Quiz.ToListAsync()
            };
            return View(viewModel);
        }

        // POST: Admin/Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QuizId,Number,Text,Img,Video,Alternative1,Alternative2,Alternative3,Alternative4,Alternative5,IsAlternative1Correct,IsAlternative2Correct,IsAlternative3Correct,IsAlternative4Correct,IsAlternative5Correct,IsMultipleChoice,Active")] Question question)
        {
            if (id != question.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            var viewModel = new QuestionViewModel()
            {
                Question = question,
                Quizzes = await _context.Quiz.ToListAsync()
            };
            return View(viewModel);
        }

        // GET: Admin/Questions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Question
                .SingleOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // POST: Admin/Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var question = await _context.Question.SingleOrDefaultAsync(m => m.Id == id);
            _context.Question.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool QuestionExists(int id)
        {
            return _context.Question.Any(e => e.Id == id);
        }
    }
}
