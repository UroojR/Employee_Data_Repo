using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourcesDataAPI.Models
{
    public class EmployeeRegistration
    {
        List<Employee> employeeList;
        static EmployeeRegistration empreg = null;
        private EmployeeRegistration()
        {
            employeeList = new List<Employee>();
        }
        public static EmployeeRegistration getInstance()
        {
            if (empreg == null)
            {
                empreg = new EmployeeRegistration();
                return empreg;
            }
            else
            {
                return empreg;
            }
        }
        public void Add(Employee employee)
        {
            employeeList.Add(employee);
        }
        public String RemoveDepartment(String department)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                Employee empList = employeeList.ElementAt(i);
                if (empList.Department.Equals(department))
                {
                    employeeList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }
            return "Delete un-successful";
        }
        ////public int RemoveEmpID(int empID)
        ////{
        ////    for (int i = 0; i < employeeList.Count; i++)
        ////    {
        ////        Employee empList = employeeList.ElementAt(i);
        ////        if (empList.EmpID.Equals(empID))
        ////        {
        ////            employeeList.RemoveAt(i);//update the new record
        ////            return 1;
        ////        }
        ////    }
        ////    return -1;
        ////}
        public List<Employee> getAllEmployees()
        {
            return employeeList;
        }

    }
}