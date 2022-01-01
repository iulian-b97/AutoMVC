using AutoMapper;
using IdentityManagement.Application.Features.User.Commands.Register;
using IdentityManagement.Domain.Entities;


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
