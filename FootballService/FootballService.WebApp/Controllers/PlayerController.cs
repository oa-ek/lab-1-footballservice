using FootballService.Core.Entities;
using FootballService.Repositories.Interfaces;
using FootballService.Repositories.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballService.WebApp.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly ITeamRepository _teamRepository;

        public PlayerController(IPlayerRepository playerRepository , ITeamRepository teamRepository)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
        }

       
        public IActionResult Index()
        {
            var players = _playerRepository.GetAll();
            return View(players);
        }

        public IActionResult Create()
        {
            ViewBag.Teams = new SelectList(_teamRepository.GetAll(), "Id", "Name");
            var positions = new List<SelectListItem>
            {
                new SelectListItem { Value = "Нападник", Text = "Нападник" },
                new SelectListItem { Value = "Півзахисник", Text = "Півзахисник" },
                new SelectListItem { Value = "Захисник", Text = "Захисник" },
                new SelectListItem { Value = "Воротар", Text = "Воротар" },

            };

            ViewBag.Positions = positions;
            return View();
        }



        [HttpPost]
        public IActionResult Create(Player player)
        {
            
            if (!ModelState.IsValid)
            {
                _playerRepository.Add(player);
                _playerRepository.Save();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        
        public IActionResult Details(int id)
        {
            var player = _playerRepository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        
        public IActionResult Edit(int id)
        {
            ViewBag.Teams = new SelectList(_teamRepository.GetAll(), "Id", "Name");

            var player = _playerRepository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        
        [HttpPost]
        public IActionResult Edit(int id, Player player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                _playerRepository.Update(player);
                _playerRepository.Save();
                return RedirectToAction("Index");
            }
            return View(player);
        }

       
        public IActionResult Delete(int id)
        {
            var player = _playerRepository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _playerRepository.Delete(id);
            _playerRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
