using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace testing.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        [DisplayName("Category")]
        public string category_id { get; set; }

    }
}