using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CLIENT.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult LoadEmployee()
        {
            //IEnumerable<EmployeeDisplayVM> employee = null;

            //var client = new HttpClient
            //{
            //    BaseAddress = new Uri(getPort.link)
            //};
            //var responseTask = client.GetAsync("Employees/GetDisplay");
            //responseTask.Wait();
            //var result = responseTask.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsAsync<IList<EmployeeDisplayVM>>();
            //    readTask.Wait();
            //    employee = readTask.Result;
            //}
            //else
            //{
            //    employee = Enumerable.Empty<EmployeeDisplayVM>();
            //    ModelState.AddModelError(string.Empty, "Server error try after some time.");
            //}
            return Json(1);
        }
    }
}