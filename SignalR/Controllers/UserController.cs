using Microsoft.AspNetCore.Mvc;
using SignalR.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateUser(CreateUserViewModel Model)
        {
            return View();
        }
    }
}
