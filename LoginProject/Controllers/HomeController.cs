using LoginProject.DatabaseModel;
using LoginProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoginProject.Controllers
{
    public class HomeController : Controller
    {
        private TestDBContext testDBcontext;
        private readonly ILogger<HomeController> _logger;
        TestDBContext testDBContext = new TestDBContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult LoginIndex()
        {
            LoginModel loginModel = new LoginModel();
            return View(loginModel);
        }
        [HttpPost]
        public IActionResult LoginIndex(LoginModel loginModel)
        {
            string message;
            int responsetypeid;
            
            //var loginstatus = testDBContext.UserLoginMasters.Where(m => m.LoginId == loginModel.LoginId && m.Password == loginModel.Password).FirstOrDefault();
            bool test = testDBContext.UserLoginMasters.Any(m => m.LoginId == loginModel.LoginId && m.Password == loginModel.Password);
            if (test)
            {
                message = "successful login";
                responsetypeid = 1;
            }
            else
            {
                message = "Invalid login detail";
                responsetypeid = 0;
            }
            return Json(new { message = message, status = responsetypeid });
        }
    }
}
