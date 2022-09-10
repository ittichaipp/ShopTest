using ShopTest1.Models;
using ShopTest1.Repository.IRepository;

namespace ShopTest1.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context) : base(context)
        {
            _context = context;
        }
    }
}
