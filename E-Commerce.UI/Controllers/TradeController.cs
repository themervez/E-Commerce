﻿using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.Entities;
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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _productService.TGetById((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
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
