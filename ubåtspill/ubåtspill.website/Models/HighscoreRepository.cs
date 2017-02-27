using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ubåtspill.website.Models
{
    public class HighscoreRepository : IHighscoreRepository
    {
        private readonly HighScoreContext _context;

        public HighscoreRepository(HighScoreContext context)
        {
            _context = context;
            
        }

        public IEnumerable<Highscore> GetAll()
        {
            return _context.Highscores.ToList();
        }
        public void Add(Highscore item)
        {
            _context.Highscores.Add(item);
            _context.SaveChanges();
        }

    }
}
