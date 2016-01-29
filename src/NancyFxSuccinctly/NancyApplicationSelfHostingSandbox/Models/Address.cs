using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;

namespace NancyApplicationSelfHostingSandbox.Models
{
    public class Address
    {
        [Required]
        public int RecordId { get; set; }
        public string Name { get; set; }
        public string BuildingAddress { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public string[] AliasList { get; set; }
    }
}
