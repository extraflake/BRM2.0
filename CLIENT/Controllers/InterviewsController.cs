using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
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

        public JsonResult InsertOrUpdate(Interview interview)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var myContent = JsonConvert.SerializeObject(interview);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if (interview.Id == 0)
            {
                var result = client.PostAsync("Interviews/FullPost", byteContent).Result;
                return Json(result);
            }
            else
            {
                var result = client.PutAsync("Interviews/FullPut/" + interview.Id, byteContent).Result;
                return Json(result);
            }
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

        public async Task<IActionResult> exporttoExcel()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            var columnHeaders = new String[]
            {
                "Number",
                "NIK",
                "Employee",
                "Date Time",
                "Customer",
                "PIC",
                "Department",
                "Notes"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("List Interview");
                using (var cells = worksheet.Cells[1, 1, 1, 8])
                {
                    cells.Style.Font.Bold = true;
                }

                for (var i = 0; i < columnHeaders.Count(); i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnHeaders[i];
                }

                var j = 2;
                HttpResponseMessage response = await client.GetAsync("Interviews/GetInterview");
                if (response.IsSuccessStatusCode)
                {
                    var readTask = await response.Content.ReadAsAsync<IList<InterviewVM>>();
                    foreach (var interview in readTask)
                    {
                        for (var x = 1; x < j; x++)
                        {
                            worksheet.Cells["A" + j].Value = x;
                        }
                        worksheet.Cells["B" + j].Value = interview.NIK;
                        worksheet.Cells["C" + j].Value = interview.Employee;
                        worksheet.Cells["D" + j].Value = interview.interview_datetime;
                        worksheet.Cells["E" + j].Value = interview.Customer;
                        worksheet.Cells["F" + j].Value = interview.PIC;
                        worksheet.Cells["G" + j].Value = interview.Department;
                        worksheet.Cells["H" + j].Value = interview.Note;
                        j++;
                    }
                }
                result = package.GetAsByteArray();
            }
            return File(result, "application/ms-excel", $"List Interview{DateTime.Now.ToString("hh:mm:ss MM/dd/yyyy")}.xlsx");
        }

        public async Task<IActionResult> Report(InterviewVM interviewVM)
        {
            InterviewList interviewList = new InterviewList();
            var readTask = await exportToPDF();
            byte[] abytes = interviewList.PrepareReport(readTask);
            return File(abytes, "application/pdf", $"Interview List{DateTime.Now.ToString("hh:mm:ss MM/dd/yyyy")}.pdf");
        }

        public async Task<List<InterviewVM>> exportToPDF()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseLink.development)
            };
            List<InterviewVM> interviewList = new List<InterviewVM>();
            var responseTask = await client.GetAsync("Interviews/GetInterview");
            interviewList = await responseTask.Content.ReadAsAsync<List<InterviewVM>>();
            return interviewList;
        }
    }
}