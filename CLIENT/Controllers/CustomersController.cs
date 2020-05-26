using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API.Models;
using API.ViewModels;
using CLIENT.Bases;
using Microsoft.AspNetCore.Mvc;

namespace CLIENT.Controllers
{
    public class CustomersController : Controller
    {
        BaseLink baseLink = new BaseLink();
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult LoadCustomer()
        {
            IEnumerable<CustomerVM> customer = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var responseTask = client.GetAsync("Customers/GetCustomer");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<CustomerVM>>();
                readTask.Wait();
                customer = readTask.Result;
            }
            else
            {
                customer = Enumerable.Empty<CustomerVM>();
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(customer);
        }

        public JsonResult LoadRM()
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

        public JsonResult LoadDistrict()
        {
            IEnumerable<District> district = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var responseTask = client.GetAsync("Districts");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<District>>();
                readTask.Wait();
                district = readTask.Result;
            }
            else
            {
                district = Enumerable.Empty<District>();
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(district);
        }
    }
}