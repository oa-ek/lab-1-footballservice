using FootballService.Core.Context;
using FootballService.Core.Entities;
using FootballService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Repos
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly FootballContext _context;
        public PlayerRepository(FootballContext context)
        {
            _context = context;
        }
        public Player GetById(int id)
        {
            return _context.Players.Include(c => c.Team).FirstOrDefault(t=>t.Id==id);
        }

        public IEnumerable<Player> GetAll()
        {
            return _context.Players.Include(c=>c.Team).ToList();
        }

        public void Add(Player player)
        {
            _context.Players.Add(player);
        }

        public void Update(Player player)
        {
            _context.Players.Update(player);
        }

        public void Delete(int id)
        {
            var team = _context.Players.Find(id);
            if (team != null)
            {
                _context.Players.Remove(team);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
