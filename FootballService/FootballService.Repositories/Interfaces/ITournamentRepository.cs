using FootballService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Interfaces
{
    public interface ITournamentRepository
    {
        Tournament GetById(int id);
        IEnumerable<Tournament> GetAll();
        void Add(Tournament tournament);
        void Update(Tournament tournament);
        void Delete(int id);
        void Save();
    }
}
