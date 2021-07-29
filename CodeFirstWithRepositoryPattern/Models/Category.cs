using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithRepositoryPattern.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Test { get; set; }
        public int AnotherTest { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}