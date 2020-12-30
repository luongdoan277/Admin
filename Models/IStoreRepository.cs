using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Media> Medias { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Customer> Customers { get; }
        IQueryable<Order> Orders { get; }
    }
}
