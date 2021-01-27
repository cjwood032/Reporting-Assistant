using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reporting_Assistant.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string UserName {get; set; }
        [Required]
        public string UserRole { get; set; }
        \
    }
}