using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Shared
{
    public class Employee
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [Required]
        public int EmployeeTypeId { get; set; }

        [Required]
        [MinLength(2,ErrorMessage = "First name must contains at least 2 characters")]
        public string FirstName { get; set; }

        [MinLength(2, ErrorMessage = "Middle name must contains at least 2 characters")]
        public string MiddleName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last name must contains at least 2 characters")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "decimal(15,2)")]
        public decimal Salary { get; set; }

        [Required]
        public int JobId { get; set; }

        public Job Job { get; set; }
    }
}
