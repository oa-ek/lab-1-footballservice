using FootballService.Core.Entities;
using FootballService.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FootballService.WebApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamRepository _teamRepository;

        public TeamController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public IActionResult Index()
        {
            var teams = _teamRepository.GetAll();
            return View(teams);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Team team)
        {
            if (!ModelState.IsValid)
            {
                _teamRepository.Add(team);
                _teamRepository.Save();
                return RedirectToAction("Index");
            }
            return View(team);
        }

        public IActionResult Details(int id)
        {
            var team = _teamRepository.GetById(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        public IActionResult Edit(int id)
        {
            var team = _teamRepository.GetById(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        [HttpPost]
        public IActionResult Edit(int id, Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                _teamRepository.Update(team);
                _teamRepository.Save();
                return RedirectToAction("Index");
            }
            return View(team);
        }

        public IActionResult Delete(int id)
        {
            var team = _teamRepository.GetById(id);
            if (team == null)
            {
                return NotFound();
            }
            return View(team);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _teamRepository.Delete(id);
            _teamRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
