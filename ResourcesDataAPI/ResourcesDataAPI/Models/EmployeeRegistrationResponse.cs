using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourcesDataAPI.Models
{
    public class EmployeeRegistrationResponse
    {
        String empName;
        public String EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        int empID;
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        String department;
        public String Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}