using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace smartPowerService.Models
{
    public class User
    {
        public int userID { get; set; }
        [Required]
        public string email { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public int number { get; set; }
    }
}
