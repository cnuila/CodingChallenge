using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{ 
    public class LoggedTime
    {
        public int Id { get; set; }
        public DateTime DateLogged { get; set; }
        public decimal Hours { get; set; }
        public int WeekNumber { get; set; }
        public int EmployeeId { get; set; }
        public int LogTypeId { get; set; }
    }
}
