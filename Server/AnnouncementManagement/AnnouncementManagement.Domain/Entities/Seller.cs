using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Domain.Entities
{
    public class Seller
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
    }
}
