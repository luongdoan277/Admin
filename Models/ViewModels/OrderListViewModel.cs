using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.ViewModels
{
    public class OrderListViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        //public IEnumerable<Customer> Customer { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
