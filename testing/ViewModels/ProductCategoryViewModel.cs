using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testing.Models;

namespace testing.ViewModels
{
    public class ProductCategoryViewModel
    {
       public Product  Product { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}