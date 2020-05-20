using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Handlers;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CLIENT.Controllers
{
    public class AccountsController : Controller
    {
        int statusCode = 400;

        public IActionResult Index()
        {
            string token = HttpContext.Session.GetString("UserToken");
            if (!string.IsNullOrWhiteSpace(token))
            {
                var role = HttpContext.Session.GetString("Role");
                if (role.Equals("Admin"))
                {
                    return RedirectToAction("Index", "Home", null, null);
                }
            }
            return View();
        }

        public JsonResult Login(LoginVM loginVM)
        {
            AccountVM accountVM = null;
            TokenGenerator tokenGenerator = new TokenGenerator();
            
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://sakura.mii.co.id:8080/APISAKURAJWT/getuserbyemail?email=" + loginVM.Email)
            };
            client.DefaultRequestHeaders.Add("Authorization", "sakura eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJzYWt1cmEiLCJpYXQiOjE1ODAxOTYxMzJ9.zYvu8-qr48lmTx7_3tZMmVmIBuGPVXmgHbFOwSdTAdYZO9FFQWa7rUeKodtfOMkzfnnjVQSl6f_t54_qvlo7cA");
            var responseTask = client.GetAsync("");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                JToken stuff1 = JObject.Parse(JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString());
                accountVM = new AccountVM()
                {
                    Email = stuff1.SelectToken("Email").ToString(),
                    Name = stuff1.SelectToken("Name").ToString(),
                    Role = stuff1.SelectToken("Role").ToString()
                };

                if (BCrypt.Net.BCrypt.Verify(loginVM.Password, stuff1.SelectToken("Password").ToString()))
                {
                    var token = tokenGenerator.Generator(accountVM);

                    HttpContext.Session.SetString("UserToken", token);
                    HttpContext.Session.SetString("Name", accountVM.Name);
                    HttpContext.Session.SetString("Email", accountVM.Email);
                    HttpContext.Session.SetString("Role", accountVM.Role);
                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        statusCode = 200;
                    }
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }
            return Json(statusCode);
        }
    }
}