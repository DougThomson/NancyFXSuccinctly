using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.Authentication.Forms;
using Nancy.ModelBinding;
using NancyApplicationSelfHostingSandbox.Models;

namespace NancyApplicationSelfHostingSandbox.modules
{
    public class AccountRoutes : NancyModule
    {
        public AccountRoutes() : base("/account")
        {
            Get[@"/login"] = _ => View["account/login"];

            Post[@"/login"] = _ =>
            {
                var loginParams = this.Bind<LoginParams>();
                FakeDatabaseUser user;
                FakeDatabase db = new FakeDatabase();

                user = db.Users.FirstOrDefault(
                    x =>
                        x.UserName.Equals(loginParams.LoginName) &&
                        x.Password.Equals(loginParams.Password));

                if (user == null)
                {
                    return View["account/loginerror"];
                }

                return this.Login(user.UserId, fallbackRedirectUrl: "http://localhost:3579/auth");
            };

            Get[@"/logout"] = _ => this.LogoutAndRedirect("http://localhost:3579/account/login");
        }
    }
}
