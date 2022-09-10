using ShopTest1.Models;
using ShopTest1.Repository.IRepository;
using ShopTest1.Service.IService;
using ShopTest1.ViewModels;
using System.Collections.Generic;

namespace ShopTest1.Service
{
    public class FormModelService : IFormModelService
    {
        private readonly IProductRepository _productRepo;
        public FormModelService(IProductRepository productQARepository)
        {
            _productRepo = productQARepository;
        }

        public FormViewModel getProduct(int id)
        {
            var x = _productRepo.ReadAsync(id);
            Product result = x.Result;
            FormViewModel formViewModel = new FormViewModel();
            if ( id > 0)
            {
                formViewModel.product = result;
            }
            return formViewModel;

        }

        public FormViewModel getProductAll()
        {
            var x =  _productRepo.ReadAllAsync();
            List<Product> result = x.Result;
            FormViewModel formViewModel = new FormViewModel();
            formViewModel.products = result;
            return formViewModel;
        }
    }

}
