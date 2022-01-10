using AnnouncementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Domain.Entities.Vehicle
{
    public class Trailer : CommonVehicle
    {
        public string NumberDoors { get; set; }
    }
}
