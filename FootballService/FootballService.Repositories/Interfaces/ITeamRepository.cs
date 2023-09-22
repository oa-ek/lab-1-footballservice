using FootballService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Team GetById(int id);
        IEnumerable<Team> GetAll();
        void Add(Team team);
        void Update(Team team);
        void Delete(int id);
        void Save();
    }
}
