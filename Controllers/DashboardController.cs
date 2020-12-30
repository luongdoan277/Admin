using Admin.Data;
using Admin.Models;
using Admin.Models.ViewModels;
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
        private readonly IStoreRepository repository;
        public int PageSize = 5;


        public DashboardController(AdminContext _adminContext, IStoreRepository repo)
        {
            repository = repo;
            adminContext = _adminContext;
        }
        //public JsonResult result()
        //{
        //    DateTime now = DateTime.Today;

        //}
        //[Authorize]
        public IActionResult Index(int productPage = 1)
        {
            DashboardProViewModel dashboard = new DashboardProViewModel
            {
                Products = repository.Products
                .OrderBy(d => d.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                },
                Orders = repository.Orders
                .OrderByDescending(d => d.OrderID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingOrder = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Orders.Count()
                },
                Revenue = new Revenue
                {
                    TotalOrder = repository.Orders.Count(),
                    TotalPrice = (decimal)repository.Orders.OrderByDescending(d => d.OrderID).Sum(p => p.TotalPrice),
                }
            };
            return View(dashboard);
        }
    }
}
