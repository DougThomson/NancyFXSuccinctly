using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;

namespace NancyApplicationSelfHostingSandbox.modules
{
    public class AddressRoutes : NancyModule
    {
        public AddressRoutes() : base("/address")
        {
            Get[@"/"] = _ => View["address/index"];
        }
    }
}
