using System.Linq;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class CabinController : Controller
    {
        private readonly DbService _dbService;

        public CabinController(DbService dbService)
        {
            _dbService = dbService;
        }

        public IActionResult Index()
        {
            var cabins = _dbService.GetCabins();
            return View(cabins);
        }

        [HttpPost]
        public IActionResult Upsert(Cabin model)
        {
            if (model.Id == 0)
            {
                _dbService.AddCabin(model);
            }
            else
            {
                _dbService.UpdateCabin(model);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var cabin = _dbService.GetCabins().FirstOrDefault(item => item.Id == id);

            if (cabin != null)
            {
                _dbService.DeleteCabin(cabin);
            }

            return RedirectToAction("Index");
        }
    }
}