using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace CateringBackend.AuthUtilities
{
    public static class JwtTokenUtilities
    {
        public static string GetAuthenticationToken(Guid userID, string userEmail, UserRole userUserRole)
        {
            var claims = new List<Claim>()
            {
                new Claim(AuthConstants.UserIdClaimType, userID.ToString()),
                new Claim(AuthConstants.UserEmailClaimType, userEmail),
                new Claim(ClaimTypes.Role, userUserRole.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(AuthConstants.JwtSigningKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                "issuer",
                "audience",
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
