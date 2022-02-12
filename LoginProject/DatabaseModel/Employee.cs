using System;
using System.Collections.Generic;

#nullable disable

namespace LoginProject.DatabaseModel
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public int? Salery { get; set; }
    }
}
