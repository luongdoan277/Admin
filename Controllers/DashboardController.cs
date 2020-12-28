using Admin.Data;
using Admin.Models;
using Microsoft.AspNetCore.Authorization;
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
        public List<Order> orders;
        private AdminContext adminContext;

        public DashboardController(AdminContext _adminContext)
        {
            adminContext = _adminContext;
        }
        //public JsonResult result()
        //{
        //    DateTime now = DateTime.Today;

        //}
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
