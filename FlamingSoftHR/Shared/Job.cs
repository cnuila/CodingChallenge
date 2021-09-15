using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Shared
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Job description must contains at least 2 characters")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(15,2)")]
        public decimal MinSalary { get; set; }

        [Required]
        [Column(TypeName = "decimal(15,2)")]
        public decimal MaxSalary { get; set; }

        [Required]
        public int DepartmentId { get; set; }
    }
}
