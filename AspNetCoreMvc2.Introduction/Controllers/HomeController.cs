using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc2.Introduction.Entities;
using AspNetCoreMvc2.Introduction.Model;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Hello from firs application";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Enis", LastName="Emir",CityId=39  },
                new Employee{Id=2, FirstName = "Melis", LastName="Emir",CityId=39  },
                new Employee{Id=3, FirstName = "Özcan", LastName="Emir",CityId=34  }
            };
            List<string> cities = new List<string> { "Ankara", "Istanbul" };

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities
            };
            return View(model);
        }

        public StatusCodeResult Index4()
        {
            return Ok();
        }

        public StatusCodeResult Index5()
        {
            return NotFound();
        }

        public RedirectResult Index6()
        {
            return Redirect("/Home/index6");
        }

        public IActionResult Index7()
        {
            return RedirectToAction("Index2");
        }

        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {

            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Enis", LastName="Emir",CityId=39  },
                new Employee{Id=2, FirstName = "Melis", LastName="Emir",CityId=39  },
                new Employee{Id=3, FirstName = "Özcan", LastName="Emir",CityId=34  }
            };
            return Json(employees);
        }

        public IActionResult RazorDemo()
        {

            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Enis", LastName="Emir",CityId=39  },
                new Employee{Id=2, FirstName = "Melis", LastName="Emir",CityId=39  },
                new Employee{Id=3, FirstName = "Özcan", LastName="Emir",CityId=34  }
            };
            List<string> cities = new List<string> { "Ankara", "Istanbul" };

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities
            };
            return View(model);
        }

        public JsonResult Index10(string key)
        {

            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Enis", LastName="Emir",CityId=39  },
                new Employee{Id=2, FirstName = "Melis", LastName="Emir",CityId=39  },
                new Employee{Id=3, FirstName = "Özcan", LastName="Emir",CityId=34  }
            };
            if (String.IsNullOrEmpty(key))
            {
                return Json(employees);
            }
            var result = employees.Where(e => e.FirstName.ToLower().Contains(key));
            return Json(result);
        }

        public ViewResult EmployeeForm()
        {
            return View();
        }


    }
}