using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{
    public class RegisterDataResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public string UserId { get; set; }
    }
}
