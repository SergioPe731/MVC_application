using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstWeb.Models;
using FirstWeb.Servises;
using Microsoft.AspNetCore.Http;

namespace FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserService _userService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       /* public IActionResult Index()
        {
            //model.Success = (model.login == "User" || model.password == "Password");
            return View();
        }*/

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy Page";
            ViewData["Test"] = "My test text";
            return View();
        }
        public IActionResult Index(LoginModel model)
        {
            HttpContext.Session.SetString("name", model.login);
            model.Success = _userService?.CheckCredentials(model.login, model.password);
            if (model.Success.HasValue && model.Success.Value)  //model.Seccess ?? false
            {
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
