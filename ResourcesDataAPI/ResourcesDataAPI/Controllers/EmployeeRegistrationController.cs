using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ResourcesDataAPI.Models;

namespace ResourcesDataAPI.Controllers
{
    public class EmployeeRegistrationController : ApiController
    {
        public EmployeeRegistrationResponse registerEmployee(Employee employeeRegd)

        {
            Console.WriteLine("In registerEmployee");
            EmployeeRegistrationResponse employeeReply = new EmployeeRegistrationResponse();
            EmployeeRegistration.getInstance().Add(employeeRegd);
            employeeReply.EmpName = employeeRegd.EmpName;
            employeeReply.EmpID = employeeRegd.EmpID;
            employeeReply.Department = employeeRegd.Department;
            return employeeReply;
        }

    }
}
