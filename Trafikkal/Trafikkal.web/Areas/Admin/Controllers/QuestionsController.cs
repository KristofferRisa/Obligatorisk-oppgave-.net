using System;
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
        private readonly ApplicationDbContext _db;

        public QuestionsController(ApplicationDbContext db)
        {
            _db = db;    
        }

        // GET: Admin/Questions
        public async Task<IActionResult> Index()
        {
            var viewModel = new QuestionsIndexViewModel()
            {
                Questions = await _db.Question.OrderBy(x => x.Number).ToListAsync(),
                Quizzes = await _db.Quiz.ToListAsync()
            };
            return View(viewModel);
        }

        // GET: Admin/Questions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _db.Question
                .SingleOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }
            var viewModel = new QuestionViewModel()
            {
                Question = question,
                Quizzes = await _db.Quiz.ToListAsync()
            };
            return View(viewModel);
        }

        // GET: Admin/Questions/Create
        public IActionResult Create()
        {
            var viewModel = new QuestionViewModel()
            {
                Quizzes = _db.Quiz.ToList()
            };
            return View(viewModel);
        }

        // POST: Admin/Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizId,Number,Text,Img,Video,Alternative1,Alternative2,Alternative3,Alternative4,Alternative5,IsAlternative1Correct,IsAlternative2Correct,IsAlternative3Correct,IsAlternative4Correct,IsAlternative5Correct,IsMultipleChoice,Active")] Question question)
        {
            question.Created = DateTime.Now;
            if (ModelState.IsValid)
            {
                _db.Add(question);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            var viewModel = new QuestionViewModel()
            {
                Question = question,
                Quizzes = await _db.Quiz.ToListAsync()
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

            
            var question = await _db.Question.SingleOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }
 
            var viewModel = new QuestionViewModel()
            {
                Question = question,
                Quizzes = await _db.Quiz.ToListAsync()
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
                    _db.Update(question);
                    await _db.SaveChangesAsync();
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
                Quizzes = await _db.Quiz.ToListAsync()
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

            var question = await _db.Question
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
            var question = await _db.Question.SingleOrDefaultAsync(m => m.Id == id);
            _db.Question.Remove(question);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool QuestionExists(int id)
        {
            return _db.Question.Any(e => e.Id == id);
        }
    }
}
