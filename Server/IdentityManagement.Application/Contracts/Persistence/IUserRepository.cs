using IdentityManagement.Application.Models;
using IdentityManagement.Application.Models.Requests;
using IdentityManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Contracts.Persistence
{
    public interface IUserRepository : IAsyncRepository<ApplicationUser>
    {
        Task<bool> ExistingUser(string email);
        Task<AuthResult> GenerateJwtToken(ApplicationUser user);
        Task<AuthResult> VerifyAndGenerateToken(TokenRequest tokenRequest);
        Task<DateTime> UnixTimeStampToDateTime(long unixTimeStamp);
        Task<string> RandomString(int length);
    }
}
