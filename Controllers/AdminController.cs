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
    public class AdminController : Controller
    {

        public AdminController()
        {
        }

        public IActionResult Index()
        {
            // ViewBag.API_SERVER = _AppSettings.API_SERVER;
            return View();
        }

        public IActionResult Login(AuthenticateRequest authenticateRequest)
        {            
            return View();
        }

        public IActionResult VocabularyTable(int id)
        {      
            ViewBag.RowNumber = id;
            return PartialView("_VocabularyTable");
        }
    }
}