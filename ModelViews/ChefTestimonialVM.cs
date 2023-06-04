using YummyEf.Entities;

namespace YummyEf.ModelViews
{
    public class ChefTestimonialVM
    {

        public IEnumerable<Testimonial> Testimonials { get; set; }

        public IEnumerable<Chef> Chefs { get; set; }

        public Chef Chef { get; set; }

        public Testimonial Testimonial { get; set; }


    }
}
