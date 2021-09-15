using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Shared
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Department name must contains at least 2 characters")]
        public string Name { get; set; }
    }
}
