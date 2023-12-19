using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyMonitoringCMC.Models
{
    public enum NodeActive
    {
        [Display(Name = "Inactive")]
        Internal = 0,
        [Display(Name = "Active")]
        External = 1
    }
    public class Node
    {
        public int NodeID { get; set; }
        [Display(Name = "Node Name")]
        public string NodeName { get; set; }
        [Display(Name = "Tree type")]
        public int TreeType { get; set; }
        [Display(Name = "Node Type")]
        public int NodeType { get; set; }
        [Display(Name = "Node Status")]
        public int NodeStatus { get; set; }
        [Display(Name = "Node Description")]
        public string NodeDescription { get; set; }
        //0 or 1 maybe should be enum
        [Display(Name = "Node active")]
        public NodeActive NodeActive { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime StatusChanged { get; set; }
        public int WindMillID { get; set; }
        public virtual WindMill WindMill { get; set; }
        public virtual List<Trend> Trends { get; set; }
    }
}