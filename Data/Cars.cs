using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMVC.Data
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string nameAd { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public string Fuel { get; set; }

        public string Body { get; set; }

        public int Year { get; set; }

        public int Km { get; set; }

        public int Price { get; set; }

        public string Describe { get; set; }

        public string ImageFileUrl { get; set; }
    }
}
