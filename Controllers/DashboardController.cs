using Admin.Models;
using Admin.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Admin.Controllers
{
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
