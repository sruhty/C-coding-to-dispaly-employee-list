using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GROUPJ_A1.Models
{
    public class Employee
    {
        public int EmployeeJId { get; set; }
        public string EmployeeJName { get; set; }

        public string EmpMugShot { get; set; }
        public Department EmpDeartment { get; set; }

        public Location EmpLocation { get; set; }
        public Employee()
        {
            EmployeeJId =EmployeeJId;
            EmployeeJName = EmployeeJName;
            EmpMugShot = EmpMugShot;
            EmpDeartment = EmpDeartment;
            EmpLocation = EmpLocation;

        }
        
    }
}