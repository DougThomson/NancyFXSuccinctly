using System;
using System.Collections.Generic;
using System.Linq;
using Nancy;
using Nancy.Authentication.Forms;
using Nancy.Security;

namespace NancyApplicationSelfHostingSandbox
{
    public class FakeDatabase : IUserMapper
    {
        List<FakeDatabaseUser> _users = new List<FakeDatabaseUser>
        {
            new FakeDatabaseUser
            {
                UserId = new Guid(01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11),
                UserName = "admin",
                Claims = new List<string> {"Admin", "Reader", "Writer" },
                Password = "admin"   
            },
            new FakeDatabaseUser
            {
                UserId = new Guid( 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12),
                UserName = "admin",
                Claims = new List<string> {"Admin", "Reader", "Writer" },
                Password = "letmeout"
            },
            new FakeDatabaseUser
            {
                UserId = new Guid(03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13),
                UserName = "admin",
                Claims = new List<string> {"Admin", "Reader", "Writer" },
                Password = "letmein"
            }
        }; 

        public IEnumerable<FakeDatabaseUser> Users => _users;

        public IUserIdentity GetUserFromIdentifier(Guid identifier, NancyContext context)
        {
            var user = _users.FirstOrDefault(x => x.UserId == identifier);

            return user == null
                ? null
                : new AuthenticatedUser
                (
                   user.UserName,
                   user.Claims
                );
        }
    }
}