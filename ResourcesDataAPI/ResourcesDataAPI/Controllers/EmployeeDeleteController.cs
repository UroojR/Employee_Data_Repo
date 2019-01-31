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
            [Route("employee/remove/{empID}")]
            public String DeleteEmployee(int empID)
            {
                Console.WriteLine("In delete Employee record");
                return EmployeeRegistration.getInstance().Remove(empID);
            }
     
    }
}
