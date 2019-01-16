using System.Collections.Generic;
using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreMvc2.Introduction.Model
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}