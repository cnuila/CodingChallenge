using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{
    public class Position
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
    }
}
