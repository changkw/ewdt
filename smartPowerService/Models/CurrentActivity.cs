using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smartPowerService.Models
{
    public class CurrentActivity
    {
        public int CurrentActivityId { get; set; }
        [Required]
        public int lighting { get; set; }
        public int machine { get; set; }
        public int alarm { get; set; }
        public int door { get; set; }
        public DateTime timeDate { get; set; }
    }
}