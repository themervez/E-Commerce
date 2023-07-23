using E_Commerce.Entities;
using System.Collections.Generic;

namespace E_Commerce.UI.Models
{
    public class CategoryListViewModel
    {
        public string SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }
    }
}
