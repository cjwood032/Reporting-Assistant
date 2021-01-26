using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reporting_Assistant.Models
{
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CategoryID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string CategoryName { get; set; }
    }
}