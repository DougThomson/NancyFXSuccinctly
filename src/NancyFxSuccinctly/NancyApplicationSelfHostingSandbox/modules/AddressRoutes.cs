using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.ModelBinding;
using NancyApplicationSelfHostingSandbox.Models;

namespace NancyApplicationSelfHostingSandbox.modules
{
    public class AddressRoutes : NancyModule
    {
        public AddressRoutes() : base("/address")
        {
            Get[@"/"] = _ => View["address/index"];

            Post[@"/save"] = _ =>
            {
                var myAddress = this.Bind<Address>(f => f.BuildingAddress, n => n.Name);
                if (myAddress != null)
                {
                    return View["address/display", myAddress];
                }

                return View["address/error"];
            };
        }
    }
}
