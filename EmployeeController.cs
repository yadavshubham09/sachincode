using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyProject.Models;
using DummyProject.Repository;

namespace DummyProject.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository EmployeeRepository;
        public EmployeeController() { EmployeeRepository = new EmployeeRepository(); }


        // Create
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(Employee employee)
        {
            EmployeeRepository.CreateEmployee(employee);
            return View();
        }

        // Fetch Employee.......
        [HttpGet]
        public ActionResult FetchEmployee()
        {
            var FetchData=EmployeeRepository.GetAllEmployee();
            return View(FetchData);
        }


    }
}