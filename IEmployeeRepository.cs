using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyProject.Models;

namespace DummyProject.Repository
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        int CreateEmployee(Employee employee);
    }
}
