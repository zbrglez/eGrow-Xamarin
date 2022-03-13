using System;
using System.Collections.Generic;
using System.Text;

namespace eGrow.Models
{
    public class User
    {

        public int userId { get; set; }
        public string userGuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public List<Devices> devices { get; set; }

    }
}
