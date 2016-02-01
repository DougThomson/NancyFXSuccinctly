using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Validation;
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
                var myAddress = this.Bind<List<Address>>().First();
                var result = this.Validate(myAddress);
                
                return result.IsValid 
                    ? View["address/display", myAddress]
                    : View["address/error"];
            };
        }
    }
}
