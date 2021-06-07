using EmployeeManagmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentApi.Models
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int departmentId);

        IEnumerable<Department> GetDepartments();
    }
}
