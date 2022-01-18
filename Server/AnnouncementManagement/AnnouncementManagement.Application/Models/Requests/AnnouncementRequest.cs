using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Models.Requests
{
    public class AnnouncementRequest
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
