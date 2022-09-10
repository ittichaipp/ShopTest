using ShopTest1.Models;
using ShopTest1.ViewModels;

namespace ShopTest1.Service.IService
{
    public interface IFormModelService
    {
        public FormViewModel getProductAll();
        public FormViewModel getProduct(int id);

    }
}
