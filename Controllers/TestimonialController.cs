using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyEf.DAL;
using YummyEf.Entities;

namespace Mazqi.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly YummyDbContext _context;

        public TestimonialController(YummyDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail( int id )
        {
            Testimonial testimonial = _context.Testimonials.Include(t=>t.Professionss).ToList().Find(t => t.Id == id);

            return View(testimonial);
        }
    }
}
