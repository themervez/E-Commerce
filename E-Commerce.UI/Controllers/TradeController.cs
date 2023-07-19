using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.Entities;
using E_Commerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace E_Commerce.UI.Controllers
{
    public class TradeController : Controller
    {
        private IProductService _productService;

        public TradeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _productService.TGetProductDetails((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(new ProductDetailsModel()
            {
                Product= product,
                Categories= product.CategoryProducts.Select(x => x.Category).ToList()    
            });
        }
        public IActionResult List(string category)
        {
            return View(new ProductListModel()
            {
                Products = _productService.TGetProductsByCategory(category)
            });
        }
    }
}
