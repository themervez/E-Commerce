using E_Commerce.BusinessLayer.Features.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.UI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)//Constructor
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
