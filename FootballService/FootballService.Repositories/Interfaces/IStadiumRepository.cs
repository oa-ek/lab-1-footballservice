using FootballService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballService.Repositories.Interfaces
{
    public interface IStadiumRepository
    {
        Stadium GetById(int id);
        IEnumerable<Stadium> GetAll();
        void Add(Stadium stadium);
        void Update(Stadium stadium);
        void Delete(int id);
        void Save();
    }
}
