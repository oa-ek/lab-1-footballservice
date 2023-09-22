using FootballService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Interfaces
{
    public interface IMatchRepository
    {
        Match GetById(int id);
        IEnumerable<Match> GetAll();
        void Add(Match match);
        void Update(Match match);
        void Delete(int id);
        void Save();
    }
}
