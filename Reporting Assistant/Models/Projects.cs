using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Reporting_Assistant.Models
{
    public class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProjectID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string ProjectName { get; set; }
        public DateTime? DateOfStart { get; set; }
        public string AvailabilityStatus { get; set; }
        public Categories category { get; set; }
    }
}