using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ResourcesDataAPI.Models;

namespace ResourcesDataAPI.Controllers
{
    public class EmployeeDeleteController : ApiController
    {
            [Route("employee/remove/{department}")]
            public String DeleteEmployeeDepartment(String department)
            {
                Console.WriteLine("In delete Employee Department");
                return EmployeeRegistration.getInstance().RemoveDepartment(department);
            }
     
    }
}
