using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyMonitoringCMC.Models
{
    public class ConnectionControl
    {
        public int ConnectionControlID { get; set; }
        public string ConnectionStatus { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CloseReason { get; set; }
        public string LastIP { get; set; }
        public string IPAddress { get; set; }
        public int WindMillID { get; set; }
        public virtual WindMill WindMill { get; set; }
        //public List<WindMill> WindMills { get; set; }
        ////public List<WindPark> WindParks { get; set; }

    }
}