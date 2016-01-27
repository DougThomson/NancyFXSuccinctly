using System;
using System.Collections.Generic;
using Nancy;

namespace NancyApplicationSelfHostingSandbox
{
    public class BaseRoutes : NancyModule
    {
        public BaseRoutes()
        {
            FirstModel demoModel = new FirstModel
            {
             //   Names =new List<string> { "Shawty", "Frank", "Alice", "Bob", "Julie", "Samantha"},
                TimeOfRequest = DateTime.Now,
                IsError = true,
                ErrorMessage = "<strong>Error message this is...</strong>"
            };

            Get[@"/base"] = _ => View["firstView/hellonancy", demoModel];

        }
    }
}
