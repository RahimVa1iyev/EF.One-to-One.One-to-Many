using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyEf.DAL;
using YummyEf.Entities;
using YummyEf.ModelViews;

namespace YummyEf.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyDbContext _context;

        public HomeController(YummyDbContext context)
        {
            this._context = context;
        }


        public IActionResult Index()
        {
            
            IEnumerable<Testimonial> testimonials = _context.Testimonials.Include(t=>t.Professionss).AsEnumerable();
            IEnumerable<Chef> chefs = _context.Chefs.Include(c => c.Profession).Include(c => c.ChefSocialMedia).AsEnumerable();

            ChefTestimonialVM model = new()
            {
                Testimonials = testimonials,
                Chefs = chefs
            };

            return View(model);
        }

       
    }
}
