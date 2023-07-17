using E_Commerce.Entities;
using System.Collections.Generic;

namespace E_Commerce.UI.Models
{
    public class ProductDetailsModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
