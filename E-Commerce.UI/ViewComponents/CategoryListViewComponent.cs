using E_Commerce.BusinessLayer.Features.Abstract;
using E_Commerce.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.UI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            return View( new CategoryListViewModel()
            {
                Categories=_categoryService.TGetList()
            });
        }   
    }
}
