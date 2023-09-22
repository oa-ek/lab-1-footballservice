using FootballService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player GetById(int id);
        IEnumerable<Player> GetAll();
        void Add(Player player);
        void Update(Player player);
        void Delete(int id);
        void Save();
    }
}
