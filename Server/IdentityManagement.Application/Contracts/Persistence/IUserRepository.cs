using IdentityManagement.Application.Models;
using IdentityManagement.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Contracts.Persistence
{
    public interface IUserRepository : IAsyncRepository<ApplicationUser>
    {
        Task<bool> ExistingUser(string email);
        Task<ApplicationUser> GetUser(string userId);
        Task<AuthResult> GenerateJwtToken(ApplicationUser user);
        Task<AuthResult> VerifyAndGenerateToken(string token, string refreshToken);
        DateTime UnixTimeStampToDateTime(long unixTimeStamp);
        string RandomString(int length);
    }
}
