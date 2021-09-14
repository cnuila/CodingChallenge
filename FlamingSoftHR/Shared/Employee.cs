using System;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared
{ 
    public class Employee
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int EmployeeTypeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int JobId { get; set; }
        //public virtual AspNetUser User { get; set; }
    }
}
