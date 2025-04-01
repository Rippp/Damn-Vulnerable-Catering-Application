using System;
using CateringBackend.AuthUtilities;

namespace CateringBackend.Exceptions
{
    public class JwtTokenDoesNotHaveUserIdClaimException : Exception
    {
        public JwtTokenDoesNotHaveUserIdClaimException() : base($"Jwt token does not have {AuthConstants.UserIdClaimType}")
        {
        }
    }
}
