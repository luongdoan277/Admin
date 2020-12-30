using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Component
{
    public class ChartDashboardViewComponent : ViewComponent
    {
        private IStoreRepository repository;
        private Chart chart { get; set; }
        private Order Order { get; set; }
        public ChartDashboardViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            decimal[] data = new decimal[12];
            for (int i = 0; i <= 11; i++)
            {
                if (i == 1) 
                {
                    var query = (decimal)repository.Orders
                    .Where(p => p.dateTime >= new DateTime(2020, (i + 1), 1) && p.dateTime <= new DateTime(2020, (i + 1), 28))
                    .OrderBy(p => p.OrderID)
                    .Sum(p => p.TotalPrice);
                    data[i] = query;
                }
                else
                {
                    if (i == 3 || i == 5 || i == 8 || i == 10 )
                    {
                        var query = (decimal)repository.Orders
                        .Where(p => p.dateTime >= new DateTime(2020, (i + 1), 1) && p.dateTime <= new DateTime(2020, (i + 1), 30))
                        .OrderBy(p => p.OrderID)
                        .Sum(p => p.TotalPrice);
                        data[i] = query;
                    }
                    else
                    {
                        if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                        {
                            var query = (decimal)repository.Orders
                            .Where(p => p.dateTime >= new DateTime(2020, (i + 1), 1) && p.dateTime <= new DateTime(2020, (i + 1), 31)) 
                            .OrderBy(p => p.OrderID)
                            .Sum(p => p.TotalPrice);
                            data[i] = query;
                        }
                    }
                }
            };
            string dataByMonth = "";
            for(int i=0; i<=11; i++)
            {
                dataByMonth = dataByMonth + data[i].ToString();
                if (i != 11)
                {
                    dataByMonth = dataByMonth + ",";
                }
            }
            var month = DateTimeFormatInfo.CurrentInfo.MonthNames;
            
            Chart chart = new Chart
            {
                MonthNames = month,
                DataByMonth = dataByMonth,
            };
            return View(chart);
        }
    }
}
