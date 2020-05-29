using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using API.ViewModels;
using CLIENT.Bases;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            IEnumerable<EmployeeRoleVM> employee = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var responseTask = client.GetAsync("Employees/GetEmployee/5");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<EmployeeRoleVM>>();
                readTask.Wait();
                employee = readTask.Result;
            }
            else
            {
                employee = Enumerable.Empty<EmployeeRoleVM>();
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

        public JsonResult GetById(string Id)
        {
            CustomerVM customer = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var responseTask = client.GetAsync("Customers/" + Id);
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                customer = JsonConvert.DeserializeObject<CustomerVM>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(customer);
        }

        public JsonResult Insert(Customer customer)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var myContent = JsonConvert.SerializeObject(customer);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (customer.Id != null)
            {
                var result = client.PostAsync("Customers", byteContent).Result;
                return Json(result);
            }
            return Json(400);
        }

        //public JsonResult Update(Customer customer, string Id)
        //{
        //    var client = new HttpClient
        //    {
        //        BaseAddress = new Uri(baseLink.development)
        //    };
        //    var myContent = JsonConvert.SerializeObject(customer);
        //    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
        //    var byteContent = new ByteArrayContent(buffer);
        //    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    if (customer.Id == Id)
        //    {
        //        var result = client.PutAsync("Customers" + customer.Id, byteContent).Result;
        //        return Json(result);
        //    }
        //    return Json(400);
        //}

        public JsonResult Update(Customer customer, string Id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var myContent = JsonConvert.SerializeObject(customer);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (customer.Id == Id)
            {
                var result = client.PutAsync("Customers/" + customer.Id, byteContent).Result;
                return Json(result);
            }
            return Json("");
        }

        public JsonResult Delete(string Id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var result = client.DeleteAsync("Customers/" + Id).Result;
            return Json(result);
        }
    }
}