using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.ViewModels
{
    public class Revenue
    {
        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalPrice { get; set; }
        public int TotalOrder { get; set; }
        public decimal AveragePrice => Math.Ceiling(TotalPrice / TotalOrder);
}
}
