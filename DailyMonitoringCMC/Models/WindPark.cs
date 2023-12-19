using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DailyMonitoringCMC.Models
{
    public class WindPark
    {
        public int WindParkID { get; set; }
        [Display(Name = "Wind Park Name")]
        [Required(ErrorMessage = "Wind park name cannot be empty")]
        public string WindParkName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        [Display(Name = "Description/Message")]
        public string Message { get; set; }
        //public int? ConnectionControlID { get; set; }
        public virtual List<WindMill> WindMills { get; set; }
        //public virtual ConnectionControl Connectioncontrol { get; set; }
    }
}