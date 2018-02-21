using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smartPowerService.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        [Required]
        public DateTime timeDate { get; set; }
        public int CurrentActivityId { get; set; }
        [ForeignKey("CurrentActivityId")]
        public CurrentActivity currentActivity { get; set; }





    }





}
