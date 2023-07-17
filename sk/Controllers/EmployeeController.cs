using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalAssignment.Models;
using FinalAssignment.Repository;

namespace FinalAssignment.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository EmployeeRepository;
        public EmployeeController() { EmployeeRepository = new EmployeeRepository(); }
        // GET: Employee
        public ActionResult FetchEmployee(string searchQuery)
        {
            var FetchData=EmployeeRepository.GetAllEmployees();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                Response.Write("<h2 style='color:red/' >Employees and Department tables join and showing joined Records...</h2>");
                // Perform the search by filtering the employees based on the search query
                FetchData = FetchData.Where(e => e.FirstName.Contains(searchQuery) || e.LastName.Contains(searchQuery) || e.DepartmentID.ToString().Contains(searchQuery));
            }


            return View(FetchData);
        }
    }
}