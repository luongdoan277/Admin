using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryIcon { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
