using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Shared
{
    public class LoggedTimeType
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Logged Time Type description must contains at least 2 characters")]
        public string Description { get; set; }
    }
}
