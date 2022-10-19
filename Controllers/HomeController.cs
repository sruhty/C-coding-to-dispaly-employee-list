using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GROUPJ_A1.Models;

namespace GROUPJ_A1.Controllers
{
    public class HomeController : Controller
    {

       public ActionResult List()
        {
            List <Employee> emps = new List<Employee>();

            Employee emp = new Employee();

            emp.EmployeeJId = 834672;
            emp.EmployeeJName = "Sruthy";
            emp.EmpMugShot = "https://thispersondoesnotexist.com/image ";
            emp.EmpDeartment.DptmtJId = 21;
            emp.EmpDeartment.DptmtJName = "Accounting";
            emp.EmpLocation.LctnJId = 103;
            emp.EmpLocation.LctnJName = "South Sales Office 4960 Clifton Hill, Niagara Falls, ON L2G 3N4";
            emps.Add(emp);

            emp.EmployeeJId = 798336;
            emp.EmployeeJName = "Romanjit";
            emp.EmpMugShot = "https://thispersondoesnotexist.com/image ";
            emp.EmpDeartment.DptmtJId = 34;
            emp.EmpDeartment.DptmtJName = "IT";
            emp.EmpLocation.LctnJId = 103;
            emp.EmpLocation.LctnJName = "South Sales Office 4960 Clifton Hill, Niagara Falls, ON L2G 3N4";
            emps.Add(emp);

            emp.EmployeeJId = 834237;
            emp.EmployeeJName = "Manthankumar";
            emp.EmpMugShot = "https://thispersondoesnotexist.com/image ";
            emp.EmpDeartment.DptmtJId = 18;
            emp.EmpDeartment.DptmtJName = "Infrastructure";
            emp.EmpLocation.LctnJId = 303;
            emp.EmpLocation.LctnJName = "West CAN Sales Office 8863 Cavendish Road, Cavendish, PEI Canada C0A 1N0";
            emps.Add(emp);

            emp.EmployeeJId = 845554;
            emp.EmployeeJName = "Satya";
            emp.EmpMugShot = "https://thispersondoesnotexist.com/image ";
            emp.EmpDeartment.DptmtJId = 21;
            emp.EmpDeartment.DptmtJName = "HR";
            emp.EmpLocation.LctnJId = 111;
            emp.EmpLocation.LctnJName = "Head Office 288 Bremner Blvd Toronto ON M5V3L9";
            emps.Add(emp);

            emp.EmployeeJId = 834670;
            emp.EmployeeJName = "Sandeep";
            emp.EmpMugShot = "https://thispersondoesnotexist.com/image ";
            emp.EmpDeartment.DptmtJId = 45;
            emp.EmpDeartment.DptmtJName = "Software Developer";
            emp.EmpLocation.LctnJId = 111;
            emp.EmpLocation.LctnJName = "Head Office 288 Bremner Blvd Toronto ON M5V3L9";
            emps.Add(emp);

            return View(emps);
        }
            
        

        public ActionResult Index()
        {
           
            return View();
        }
    }
}
    
