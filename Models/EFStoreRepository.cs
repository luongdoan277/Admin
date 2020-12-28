using Admin.Data;
using System.Linq;

namespace Admin.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private AdminContext context;

        public EFStoreRepository(AdminContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Media> Medias => context.Medias;
        public IQueryable<Customer> Customers => context.Customers;

    }
}
