using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{
    public class Job
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public int DepartmentId { get; set; }
    }
}
