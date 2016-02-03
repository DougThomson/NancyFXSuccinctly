using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;

namespace NancyApplicationSelfHostingSandbox.modules
{
    public class AuthRoutes : NancyModule
    {
        public AuthRoutes() : base("auth")
        {
            Get[@"/"] = _ => View["auth/index"];

        }
    }
}
