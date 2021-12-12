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
using FirstWeb.Models;

namespace FirstWeb.Controllers
{
     
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserService _userService;
        public UserService SaveAuthor;
        public dbUsers CurrentUser;
        public User DataCurUser;
       // public list<User> person;
        public int induser;
        public string Loginstr;
        public string Passwordstr;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _userService = new UserService();
            CurrentUser = new dbUsers();
            DataCurUser = new User();
            ViewData["CurrentUser"] = DataCurUser.login;
            //TempData["CurrentData"] = new LoginModel();
        }

        /* public IActionResult Index()
         {
             //model.Success = (model.login == "User" || model.password == "Password");
             return View();
         }*/
        [HttpGet]
        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy Page";
            ViewData["Test"] = "My test text";
            //var model1 = TempData["CurrentData"];
           // var CurrentUser1 = CurrentUser.Users.Where(x => x.login == model1.login && x.password == model1.password).ToList();
           // DataCurUser = CurrentUser1[0];
            ViewData["CurrentUser"] = TempData["CurrentData"];
            return View();
        }


        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
       

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
           
            // model.Success = SaveAuthor.CheckCredentials(model.login, model.password);
            //  ViewData["CurrentUser"] = SaveAuthor.AuthorizUser.login+"\n"+ SaveAuthor.AuthorizUser.password + "\n" + SaveAuthor.AuthorizUser.BirthDate;
            model.Success = _userService?.CheckCredentials(model.login, model.password);
            if (model.Success.HasValue && model.Success.Value)  //model.Seccess ?? false
            {
                var CurrentUser1 = CurrentUser.Users.Where(x => x.login == model.login && x.password == model.password).ToList();
                DataCurUser = CurrentUser1[0];
                TempData["CurrentData"] = DataCurUser.fullName + "\nЛогин: " + DataCurUser.login + " Пароль: " +
                    DataCurUser.password + "\nДата рождения: " + DataCurUser.BirthDate;
                return RedirectToAction("Privacy", "Home");

            }
            return RedirectToAction("Error", "Home");
           
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


        [HttpGet]
        public IActionResult Error(LoginModel model)
        {
            model.login = "Неверно введены логин или пароль.";
            model.password = "Пользователей с такой учётной записью в базе данных не существует.";
            return View(model);
           // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Error()
        {
            return RedirectToAction("Index", "Home");
            // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Privacy(LoginModel model)
        {
            return RedirectToAction("Index", "Home");
            // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
