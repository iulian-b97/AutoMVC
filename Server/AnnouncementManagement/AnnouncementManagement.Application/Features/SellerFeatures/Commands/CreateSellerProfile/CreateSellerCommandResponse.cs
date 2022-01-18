using AnnouncementManagement.Application.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.SellerFeatures.Commands.CreateSellerProfile
{
    public class CreateSellerCommandResponse
    {
        public SellerResponse Seller { get; set; }
    }
}
