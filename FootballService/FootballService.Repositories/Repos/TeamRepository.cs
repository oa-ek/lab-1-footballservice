using FootballService.Core.Context;
using FootballService.Core.Entities;
using FootballService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Repos
{
    public class TeamRepository : ITeamRepository
    {
        private readonly FootballContext _context;

        public TeamRepository(FootballContext context)
        {
            _context = context;
        }

        public Team GetById(int id)
        {
            return _context.Teams.Find(id);
        }

        public IEnumerable<Team> GetAll()
        {
            return _context.Teams.ToList();
        }

        public void Add(Team team)
        {
            _context.Teams.Add(team);
        }

        public void Update(Team team)
        {
            _context.Teams.Update(team);
        }

        public void Delete(int id)
        {
            var team = _context.Teams.Find(id);
            if (team != null)
            {
                _context.Teams.Remove(team);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}
