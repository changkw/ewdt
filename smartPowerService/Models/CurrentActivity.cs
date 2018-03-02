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
        public int Lighting { get; set; }
        public int Machine { get; set; }
        public int Alarm { get; set; }
        public int Door { get; set; }
        public DateTime Timedate { get; set; }
    }
}
