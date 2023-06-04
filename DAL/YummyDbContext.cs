using Microsoft.EntityFrameworkCore;
using YummyEf.Entities;

namespace YummyEf.DAL
{
    public class YummyDbContext:DbContext
    {
        public YummyDbContext(DbContextOptions<YummyDbContext> options):base(options)
        {

        }

        public DbSet<Chef> Chefs { get; set; }

        public DbSet<ChefSocialMedia> ChefSocialMedias { get; set; }

        public DbSet<Profession> Professions { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
