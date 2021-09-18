using System;
using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Shared
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
