using EmployeeManagmentModels;
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

        protected bool IsSelected { get; set; }
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            
            await OnEmployeeSelection.InvokeAsync((bool)e.Value);

        }
    }
}
