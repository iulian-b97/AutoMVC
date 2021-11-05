using IdentityManagement.Application.Contracts.Persistence;
using IdentityManagement.Application.Models;
using IdentityManagement.Application.Models.Requests;
using IdentityManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Infrastructure.Persistence.Repositories
{
    public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository
    {
        public Task<bool> ExistingUser(string email)
        {
            throw new NotImplementedException();
        }

        public Task<AuthResult> GenerateJwtToken(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<string> RandomString(int length)
        {
            throw new NotImplementedException();
        }

        public Task<DateTime> UnixTimeStampToDateTime(long unixTimeStamp)
        {
            throw new NotImplementedException();
        }

        public Task<AuthResult> VerifyAndGenerateToken(TokenRequest tokenRequest)
        {
            throw new NotImplementedException();
        }
    }
}
