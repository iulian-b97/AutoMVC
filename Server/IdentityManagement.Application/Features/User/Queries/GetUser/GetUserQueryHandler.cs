using IdentityManagement.Application.Contracts.Persistence;
using IdentityManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, ApplicationUser>
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ApplicationUser> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUser(request.UserId);

            if(user == null)
            {
                return null;
            }

            return user;
        }
    }
}
