using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{
    public class EmployeeDataResult
    {
        public IEnumerable<Employee> Employees { get; set; }
        public int Count { get; set; }

    }
}
