using EmployeeManagmentModels.CustomValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EmployeeManagmentModels;

namespace EmployeeManagmentWeb.Models
{
    public class EditEmployeeModel
    {
      
            public int EmployeeId { get; set; }
            [Required(ErrorMessage = "FirstName must be provided")]
            [MinLength(2)]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }

            [EmailDomainValidator(AllowedDomain = "pragimtech.com",
                ErrorMessage = "Only PragimTech.com is allowed")]
            public string Email { get; set; }
            public DateTime DateOfBrith { get; set; }
            public Gender Gender { get; set; }
            public int DepartmentId { get; set; }
            public string PhotoPath { get; set; }
            public Department Department { get; set; }
        }
    }

