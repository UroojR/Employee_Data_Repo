using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ResourcesDataAPI.Models;

namespace ResourcesDataAPI.Controllers
{
    public class EmployeeDataController : ApiController
    {
        public List<Employee> GetAllEmployees()
        {
            return EmployeeRegistration.getInstance().getAllEmployees();
        }
    }
}
