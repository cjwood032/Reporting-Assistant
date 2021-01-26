using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reporting_Assistant.Models
{
    public class Projects
    {
        public long ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime? DateOfStart { get; set; }
        public string AvailabilityStatus { get; set; }
        public Categories category { get; set; }
    }
}