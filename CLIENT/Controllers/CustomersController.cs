using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using API.ViewModels;
using CLIENT.Bases;
using CLIENT.Report;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;

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

        public async Task<IActionResult> exporttoExcel()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var columnHeaders = new String[]
            {
                "Number",
                "ID",
                "Customer Name",
                "Customer Address",
                "Customer Phone",
                "Relation Manager",
                "Relation Manager ID",
                "District",
                "Relation Manager Phone Number"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("List Customer");
                using (var cells = worksheet.Cells[1, 1, 1, 9])
                {
                    cells.Style.Font.Bold = true;
                }

                for (var i = 0; i < columnHeaders.Count(); i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnHeaders[i];
                }

                var j = 2;
                HttpResponseMessage response = await client.GetAsync("Customers/GetCustomer");
                if (response.IsSuccessStatusCode)
                {
                    var readTask = await response.Content.ReadAsAsync<IList<CustomerVM>>();
                    foreach (var customer in readTask)
                    {
                        for (var x = 1; x < j; x++)
                        {
                            worksheet.Cells["A" + j].Value = x;
                        }
                        worksheet.Cells["B" + j].Value = customer.Id;
                        worksheet.Cells["C" + j].Value = customer.Name;
                        worksheet.Cells["D" + j].Value = customer.Address;
                        worksheet.Cells["E" + j].Value = customer.Phone;
                        worksheet.Cells["F" + j].Value = customer.relation_manager;
                        worksheet.Cells["G" + j].Value = customer.employee_id;
                        worksheet.Cells["H" + j].Value = customer.district;
                        worksheet.Cells["I" + j].Value = customer.phone_relation_manager;
                        j++;
                    }
                }
                result = package.GetAsByteArray();
            }
            return File(result, "application/ms-excel", $"ListCustomer{DateTime.Now.ToString("hh:mm:ss MM/dd/yyyy")}.xlsx");
        }

        public async Task<IActionResult> Report(CustomerVM customerVM)
        {
            CustList custList = new CustList();
            var readTask = await exportToPDF();
            byte[] abytes = custList.PrepareReport(readTask);
            return File(abytes, "application/pdf", $"Customer List{DateTime.Now.ToString("hh:mm:ss MM/dd/yyyy")}.pdf");
        }

        public async Task<List<CustomerVM>> exportToPDF()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            List<CustomerVM> custList = new List<CustomerVM>();
            var responseTask = await client.GetAsync("Customers/GetCustomer");
            custList = await responseTask.Content.ReadAsAsync<List<CustomerVM>>();
            return custList;
        }
    }
}