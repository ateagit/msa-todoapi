using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todoapi.Model
{
    public partial class Task
    {
        public int TaskId { get; set; }
        [StringLength(255)]
        public string TaskName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
    }
}
