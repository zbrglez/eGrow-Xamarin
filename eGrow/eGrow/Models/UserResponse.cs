using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eGrow.Models
{
    public class UserResponse
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
