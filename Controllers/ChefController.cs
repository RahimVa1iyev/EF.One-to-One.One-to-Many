using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyEf.DAL;
using YummyEf.Entities;

namespace Mazqi.Controllers
{
    public class ChefController : Controller
    {

        private readonly YummyDbContext _context;

        public ChefController(YummyDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail( int id)
        {
            Chef chef = _context.Chefs.Include(c => c.Profession).Include(c=>c.ChefSocialMedia).ToList().Find(x => x.Id == id);

            return View(chef);
        }
    }
}
