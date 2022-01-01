using IdentityManagement.Application.Contracts.Persistence;
using IdentityManagement.Application.Models;
using IdentityManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Infrastructure.Persistence.Repositories
{
    public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository
    {
        private readonly JwtConfig _jwtConfig;
        private readonly AuthenticationContext _authenticationContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(IOptionsMonitor<JwtConfig> optionsMonitor,
            AuthenticationContext authenticationContext,
            UserManager<ApplicationUser> userManager)
        {
            _jwtConfig = optionsMonitor.CurrentValue;
            _userManager = userManager;
            _authenticationContext = authenticationContext;
        }

        public Task<bool> ExistingUser(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> GetUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if(user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<AuthResult> GenerateJwtToken(ApplicationUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] 
                {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddSeconds(30), // 5-10 
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            var refreshToken = new RefreshToken()
            {
                JwtId = token.Id,
                IsUsed = false,
                IsRevorked = false,
                UserId = user.Id,
                AddedDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddDays(1),
                Token = RandomString(35) + Guid.NewGuid()
            };

            await _authenticationContext.RefreshTokens.AddAsync(refreshToken);
            await _authenticationContext.SaveChangesAsync();

            return new AuthResult()
            {
                Token = jwtToken,
                Success = true,
                RefreshToken = refreshToken.Token
            };
        }

        public async Task<AuthResult> VerifyAndGenerateToken(string token, string refreshToken)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                // validation 1 - validate existence of the token
                var storedToken = await _authenticationContext.RefreshTokens.FirstOrDefaultAsync(x => x.Token == refreshToken);

                if (storedToken == null)
                {
                    return new AuthResult()
                    {
                        Success = false,
                        Errors = new List<string>() {
                            "Token does not exist"
                        }
                    };
                }

                // Validation 2 - validate if used
                if (storedToken.IsUsed)
                {
                    return new AuthResult()
                    {
                        Success = false,
                        Errors = new List<string>() {
                            "Token has been used"
                        }
                    };
                }

                // Validation 3 - validate if revoked
                if (storedToken.IsRevorked)
                {
                    return new AuthResult()
                    {
                        Success = false,
                        Errors = new List<string>() {
                            "Token has been revoked"
                        }
                    };
                }

                // Update current token 
                storedToken.IsUsed = true;
                 _authenticationContext.RefreshTokens.Update(storedToken);
                 await _authenticationContext.SaveChangesAsync();

                // Remove expired tokens from database
                var list = _authenticationContext.RefreshTokens.ToList();
                if(list.Count >= 1000)
                {
                    _authenticationContext.RefreshTokens.RemoveRange(list);
                }

                // Generate a new token
                var dbUser = await _userManager.FindByIdAsync(storedToken.UserId);
                return await GenerateJwtToken(dbUser);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Lifetime validation failed. The token is expired."))
                {

                    return new AuthResult()
                    {
                        Success = false,
                        Errors = new List<string>() {
                            "Token has expired please re-login"
                        }
                    };

                }
                else
                {
                    return new AuthResult()
                    {
                        Success = false,
                        Errors = new List<string>() {
                            "Something went wrong."
                        }
                    };
                }
            }
        }

        public DateTime UnixTimeStampToDateTime(long utcExpiryDate)
        {
            var dateTimeVal = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(utcExpiryDate).ToUniversalTime();

            return dateTimeVal;
        }

        public string RandomString(int length)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(x => x[random.Next(x.Length)]).ToArray());
        }
    }
}
