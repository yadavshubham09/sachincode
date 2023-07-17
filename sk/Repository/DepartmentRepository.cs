using FinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalAssignment.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        FinalAssignmentDBEntities _contextDB;
        public DepartmentRepository() { _contextDB = new FinalAssignmentDBEntities(); }
        void IDepartmentRepository.AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        void IDepartmentRepository.DeleteDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Department> IDepartmentRepository.GetAllDepartments()
        {
            return _contextDB.Departments.ToList(); 
        }

        Department IDepartmentRepository.GetDepartmentById(int departmentId)
        {
            throw new NotImplementedException();
        }

        void IDepartmentRepository.UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}