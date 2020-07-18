using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AutoMVC.Controllers
{
    public class AddNewAdController : Controller
    {
        public IActionResult AddNewAd()
        {
            return View();
        }
    }
}
