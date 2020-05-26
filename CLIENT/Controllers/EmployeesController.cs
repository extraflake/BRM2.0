using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API.ViewModels;
using CLIENT.Bases;
using Microsoft.AspNetCore.Mvc;

namespace CLIENT.Controllers
{
    public class EmployeesController : Controller
    {
        BaseLink baseLink = new BaseLink();

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult LoadEmployee()
        {
            IEnumerable<EmployeeVM> employee = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var responseTask = client.GetAsync("Employees/GetEmployee");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<EmployeeVM>>();
                readTask.Wait();
                employee = readTask.Result;
            }
            else
            {
                employee = Enumerable.Empty<EmployeeVM>();
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(employee);
        }
    }
}