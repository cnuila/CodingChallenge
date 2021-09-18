using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{
    public class JobDataResult
    {
        public IEnumerable<Job> Jobs { get; set; }
        public int Count { get; set; }
    }
}
