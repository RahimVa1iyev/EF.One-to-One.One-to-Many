namespace YummyEf.Entities
{
    public class Profession
    {
        public int Id { get; set; }

        public string Name { get; set; }

        ICollection<Chef> Chefs { get; set; }

        ICollection<Testimonial> Testimonials { get; set; } 

    }
}
