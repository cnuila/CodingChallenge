using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Shared
{ 
    public class EmployeeType
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Employee Type description must contains at least 2 characters")]
        public string Description { get; set; }
    }
}
