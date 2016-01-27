﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NancyApplicationSelfHostingSandbox
{
    public class FirstModel
    {
        public List<string> Names { get; set; }
        public DateTime TimeOfRequest { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
    }
}
