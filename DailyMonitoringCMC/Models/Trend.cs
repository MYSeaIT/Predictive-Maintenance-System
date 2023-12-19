using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyMonitoringCMC.Models
{
    public class Trend
    {
        public int TrendID { get; set; }
        public DateTime ReadingTime { get; set; }
        public double F1Amp { get; set; }
        public double F2Amp { get; set; }
        public double F3Amp { get; set; }
        public double F4Amp { get; set; }
        public double F5Amp { get; set; }
        public double F1Phase { get; set; }
        public double F2Phase { get; set; }
        public double F3Phase { get; set; }
        public double F4Phase { get; set; }
        public double F5Phase { get; set; }
        public double F1HA { get; set; }
        public double F2HA { get; set; }
        public double F3HA { get; set; }
        public double F4HA { get; set; }
        public double F5HA { get; set; }
        public double F1HW { get; set; }
        public double F2HW { get; set; }
        public double F3HW { get; set; }
        public double F4HW { get; set; }
        public double F5HW { get; set; }
        public int F1Status { get; set; }
        public int F2Status { get; set; }
        public int F3Status { get; set; }
        public int F4Status { get; set; }
        public int F5Status { get; set; }
        public double Speed { get; set; }
        public double Process { get; set; }
        public int Digital { get; set; }
        public int StorageReason { get; set; }
        public double BOV { get; set; }
        public int NodeID { get; set; }
        public virtual Node Node { get; set; }


    }
}