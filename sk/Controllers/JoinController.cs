using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalAssignment.Models;
using FinalAssignment.Repository;

namespace FinalAssignment.Controllers
{
    public class JoinController : Controller
    {
        IEmployeeRepository EmployeeRepository;
        IDepartmentRepository DepartmentRepository;

        public JoinController()
        {
            EmployeeRepository = new EmployeeRepository();
            DepartmentRepository = new DepartmentRepository();
        }


        // GET: Join

        public ActionResult JoinTables()
        {
            var employees = (List<Employee>)EmployeeRepository.GetAllEmployees();
            var departments = (List<Department>)DepartmentRepository.GetAllDepartments();

            // Perform the join operation
            var joinedData = (from emp in employees
                             join dept in departments on emp.DepartmentID equals dept.DepartmentID
                             select new { emp,dept }).ToList();


            // Pass he joined data to the view
            Response.Write(joinedData);
            return View();
        }
    }
}