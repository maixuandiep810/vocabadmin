using System.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vocabadmin.Models;
using vocabadmin.Helpers;
using Microsoft.Extensions.Options;

namespace vocabadmin.Controllers
{
    public class AccountController : Controller
    {

        private readonly AppSettings _AppSettings;

        public AccountController(IOptions<AppSettings> appSettings)
        {
            _AppSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(AuthenticateRequest authenticateRequest)
        {
            HttpContext.Response.Headers.Add("", "");
            return View();
        }
    }
}