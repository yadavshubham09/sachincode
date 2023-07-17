using FinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebSockets;

namespace FinalAssignment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private FinalAssignmentDBEntities _contextDB;
        public EmployeeRepository() { _contextDB = new FinalAssignmentDBEntities(); }
        void IEmployeeRepository.AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        void IEmployeeRepository.DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IEmployeeRepository.GetAllEmployees()
        {
           return _contextDB.Employees.ToList();
        }

        Employee IEmployeeRepository.GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        void IEmployeeRepository.UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}