﻿namespace YummyEf.Entities
{
    public class Testimonial
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string About { get; set; }

        public int ProfessionId { get; set; }


        public Profession Professionss  { get; set; }


    }
}
