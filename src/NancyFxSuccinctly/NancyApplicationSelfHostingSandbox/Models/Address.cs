using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NancyApplicationSelfHostingSandbox.Models
{
    public class Address
    {
        public int RecordId { get; set; }
        public string Name { get; set; }
        public string BuildingAddress { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
    }
}
