using Microsoft.AspNetCore.Mvc;
using ShopTest1.Models;
using ShopTest1.Service;
using ShopTest1.Service.IService;
using ShopTest1.ViewModels;
using System.Diagnostics;

namespace ShopTest1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFormModelService _formModelService;

        public HomeController(ILogger<HomeController> logger, FormModelService formModelService)
        {
            _logger = logger;
            _formModelService = formModelService;
        }

        public IActionResult Index()
        {
            FormViewModel formViewModel = new FormViewModel();
            formViewModel = _formModelService.getProductAll();
            return View(formViewModel);
        }
        

        public IActionResult Detail(int id)
        {
            FormViewModel formViewModel = new FormViewModel();
            formViewModel = _formModelService.getProduct(id);
            return View(formViewModel);
        }

       
    }
}