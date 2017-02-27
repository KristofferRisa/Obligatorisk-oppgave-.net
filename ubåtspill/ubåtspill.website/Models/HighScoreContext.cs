using System;
using Microsoft.EntityFrameworkCore;

namespace ubåtspill.website.Models
{
    public class HighscoreContext : DbContext
    {
        public HighscoreContext(DbContextOptions<HighscoreContext> options)
            : base(options)
        {
        }

        public DbSet<Highscore> Highscores { get; set; }


    }

    public class Highscore
    {
        public int HighscoreId { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public DateTime Date { get; set; }
    }
}