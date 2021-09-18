using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Shared
{ 
    public class LoggedTime
    {
        public int Id { get; set; }
        public DateTime DateLogged { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,2)")]
        [Range(minimum:0,maximum:12,ErrorMessage = "The hours must be between 0.00 and 12.00")]
        public decimal Hours { get; set; }

        [Required]
        public int LoggedTimeTypeId { get; set; }

        public int WeekNumber { get; set; }
        public int EmployeeId { get; set; }

        public LoggedTimeType LoggedTimeType { get; set; }
    }
}
