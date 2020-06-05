using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using API.Models;
using API.ViewModels;
using CLIENT.Bases;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CLIENT.Controllers
{
    public class InterviewsController : Controller
    {
        BaseLink baseLink = new BaseLink();

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult LoadInterview()
        {
            IEnumerable<InterviewVM> interview = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var responseTask = client.GetAsync("Interviews/GetInterview");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<InterviewVM>>();
                readTask.Wait();
                interview = readTask.Result;
            }
            else
            {
                interview = Enumerable.Empty<InterviewVM>();
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(interview);
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

        public JsonResult GetById(int Id)
        {
            InterviewVM interview = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var responseTask = client.GetAsync("Interviews/" + Id);
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                interview = JsonConvert.DeserializeObject<InterviewVM>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(interview);
        }

        public JsonResult Delete(string Id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var result = client.DeleteAsync("Interviews/" + Id).Result;
            return Json(result);
        }
    }
}