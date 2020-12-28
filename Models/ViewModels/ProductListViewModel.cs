using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Media> Medias { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
