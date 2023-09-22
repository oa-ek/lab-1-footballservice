using FootballService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Interfaces
{
    public interface ICoachRepository
    {
        Coach GetById(int id);
        IEnumerable<Coach> GetAll();
        void Add(Coach coach);
        void Update(Coach coach);
        void Delete(int id);
        void Save();
    }
}
