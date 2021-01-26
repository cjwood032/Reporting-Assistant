using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Reporting_Assistant.Models
{
    public class TasksDone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TaskDoneID { get; set; }
        [MaxLength(50)]
        [MinLength(2)]
        public string Screen { get; set; }
        [MaxLength(1000)]
        [MinLength(2)]
        public string Description { get; set; }
        
        [ForeignKey("User")]
        public long UserID { get; set; }
        public string Attachment { get; set; }
        [Required]
        public DateTime DateOfTaskDone { get; set; }
        [ForeignKey("Projects")]
        public long ProjectID { get; set; }
    }
}