using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DailyMonitoringCMC.Models
{
    public class WindMill
    {
        public int WindMillID { get; set; }
        [Display(Name = "Description/Message")]
        public string WindMillName { get; set; }
        public int WindParkID { get; set; }
        //public int ConnectionControlID { get; set; }
        public int LocationID { get; set; }
        public virtual WindPark Windpark { get; set; }
        public virtual Location Location { get; set; }
        public virtual List<ConnectionControl> Connectioncontrols { get; set; }
        public List<Node> Nodes { get; set; }
    }
}