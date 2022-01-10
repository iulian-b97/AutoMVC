using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Domain.Entities
{
    public class Announcement
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
