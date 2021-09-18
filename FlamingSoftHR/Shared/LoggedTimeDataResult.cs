using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{
    public class LoggedTimeDataResult
    {
        public IEnumerable<LoggedTime> LoggedTimes { get; set; }
        public int Count { get; set; }
    }
}
