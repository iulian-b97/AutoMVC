using AnnouncementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Domain.Entities
{
    public class Motorcycle : CommonVehicle
    {
        public int Km { get; set; }
        public int HP { get; set; }
        public int Cm3 { get; set; }
        public string Gearbox { get; set; }
    }
}
