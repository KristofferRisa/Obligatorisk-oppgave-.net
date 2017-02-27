using System.Collections.Generic;

namespace ubåtspill.website.Models
{
    public interface IHighscoreRepository
    {
        void Add(Highscore item);
        IEnumerable<Highscore> GetAll();

    }
}
