using System.Collections.Generic;
using Nancy.Security;

namespace NancyApplicationSelfHostingSandbox
{
    public class AuthenticatedUser : IUserIdentity
    {
        public AuthenticatedUser(string userName, IEnumerable<string> claims )
        {
            UserName = userName;
            Claims = claims;
        }
        public string UserName { get; }
        public IEnumerable<string> Claims { get; }
    }
}