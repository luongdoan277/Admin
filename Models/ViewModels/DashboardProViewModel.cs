using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.ViewModels
{
    public class DashboardProViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public PagingInfo PagingOrder { get; set; }
        public Revenue Revenue { get; set; }
    }
}
