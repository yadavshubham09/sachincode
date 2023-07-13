using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DummyProject.Models;

namespace DummyProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        DBDummyProjectEntities DBDummyObj;
        public EmployeeRepository() { DBDummyObj = new DBDummyProjectEntities();  }
        int IEmployeeRepository.CreateEmployee(Employee employee)
        {
            if(employee == null) return 0;
            else
            {
                DBDummyObj.Employees.Add(employee);
                DBDummyObj.SaveChanges();
                return 1;
            }
        }

        IEnumerable<Employee> IEmployeeRepository.GetAllEmployee()
        {
            return DBDummyObj.Employees.ToList();
        }
    }
}