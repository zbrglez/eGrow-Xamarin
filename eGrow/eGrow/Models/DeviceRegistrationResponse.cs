using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eGrow.Models
{
    public class DeviceRegistrationResponse
    {
        [Required]
        public string deviceGuid { get; set; }
    }
}
