﻿using EmployeeManagmentModels;
using EmployeeManagmentWeb.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentWeb.Pages
{
    public class DisplayEmployeeBase : ComponentBase

    {      
        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

      
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task Delete_Click()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);
            NavigationManager.NavigateTo("/", true);
        }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            
            await OnEmployeeSelection.InvokeAsync((bool)e.Value);

        }
    }
}
