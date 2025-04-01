using System;
using System.Linq;
using CateringBackend.Exceptions;
using Microsoft.AspNetCore.Http;

namespace CateringBackend.AuthUtilities
{
    public interface IUserIdFromTokenProvider
    {
        public Guid GetUserIdFromContextOrThrow(HttpContext httpContext);
    }

    public class UserIdFromTokenProvider : IUserIdFromTokenProvider
    {
        public Guid GetUserIdFromContextOrThrow(HttpContext httpContext)
        {
            var userIdClaim = httpContext?.User?.Claims.FirstOrDefault(claim => claim.Type == AuthConstants.UserIdClaimType);
            if (userIdClaim == default)
            {
                throw new JwtTokenDoesNotHaveUserIdClaimException();
            }
            return Guid.Parse(userIdClaim.Value);
        }
    }
}
