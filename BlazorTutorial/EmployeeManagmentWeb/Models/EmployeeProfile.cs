using System;
using AutoMapper;
using EmployeeManagmentModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentWeb.Models
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EditEmployeeModel>()
            .ForMember(dest => dest.ConfirmEmail,
                      opt => opt.MapFrom(src => src.Email));
            CreateMap< EditEmployeeModel, Employee>();
        }
    }
}
