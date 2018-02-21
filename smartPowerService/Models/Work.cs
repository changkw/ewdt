using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smartPowerService.Models
{
    public class Work
    {
        public int workID { get; set; }
        [Required]
        public DateTime startTime { get; set; }
        public DateTime? endTime { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public User user { get; set; }
    }
}