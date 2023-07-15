using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.UI.Controllers
{
    public class TradeController : Controller
    {
        private IProductService _productService;

        public TradeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult List()
        {
            return View(new ProductListModel()
            {
                Products = _productService.TGetList()
            });
        }
    }
}
