using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Models.Requests.VehicleRequests
{
    public class VanRequest
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Body { get; set; }
        public string ColorBody { get; set; }
        public int Km { get; set; }
        public int HP { get; set; }
        public int Cm3 { get; set; }
        public string Gearbox { get; set; }
        public int Speeds { get; set; }
        public int Cylinders { get; set; }
        public string Traction { get; set; }
        public string Paint { get; set; }
        public int NumberDoors { get; set; }
        public int NumberSeats { get; set; }
        public int Weight { get; set; }
    }
}
