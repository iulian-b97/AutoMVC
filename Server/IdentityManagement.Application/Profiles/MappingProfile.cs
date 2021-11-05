using AutoMapper;
using IdentityManagement.Application.Features.User.Commands.Register;
using IdentityManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserRegistrationCommand>();
        }
    }
}
