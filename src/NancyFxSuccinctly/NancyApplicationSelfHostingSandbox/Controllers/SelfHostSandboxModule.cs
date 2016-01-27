using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Nancy;
using Nancy.Hosting.Self;

namespace NancyApplicationSelfHostingSandbox.Controllers
{

    public class SelfHostSandboxModule : NancyModule
    {
        public SelfHostSandboxModule() //: base(@"/people")
        {
            Get[@"/self"] = parameters => View["orgindex"];
            //Response.AsFile("index.html", "text/html");
            Put[@"/single"] = _ => Response.AsFile("index.html", "text/html");
            Post[@"/new"] = _ =>
            {
                return Response.AsFile("index.html", "text/html");
            };
            Delete[@"/single"] = _ => Response.AsFile("index.html", "text/html");
        }
    }
}

