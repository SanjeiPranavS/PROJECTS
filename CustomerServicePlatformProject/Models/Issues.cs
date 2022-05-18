using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerServicePlatformProject.Models
{
    public enum PriorityValues
    {
        High = 1,
        Medium,
        Low
    }
    public class Issue
    {
        public string IssueDescription { get; set; }

        public int CreatedByUserId { set; get; }


        public long IssueId { get; set; }

        public DateTime DateTime { get; } = DateTime.Now;

        public PriorityValues PriorityValue { set; get; }
    }
        
}
   

