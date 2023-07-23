using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.Entities;
using E_Commerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace E_Commerce.UI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(new ProductListModel()
            {
                Products = _productService.TGetList()
            });
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductModel p)
        {
            var product = new Product()
            {
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                ImageUrl = p.ImageUrl
            };

            _productService.TInsert(product);

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var values = _productService.TGetById((int)id);

            if (values == null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                ID = values.ID,
                Name = values.Name,
                ImageUrl = values.ImageUrl,
                Description = values.Description,
                Price = values.Price
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel p)
        {
            var values = _productService.TGetById(p.ID);
            if (values == null)
            {
                return NotFound();
            }
            values.Name = p.Name;
            values.ImageUrl = p.ImageUrl;
            values.Description = p.Description;
            values.Price = p.Price;

            _productService.TUpdate(values);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var values = _productService.TGetById(id);
            if (values != null)
            {
                _productService.TDelete(values);
            }
            return RedirectToAction("Index");
        }
    }
}
