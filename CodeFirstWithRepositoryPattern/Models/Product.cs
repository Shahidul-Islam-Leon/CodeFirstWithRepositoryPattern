using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithRepositoryPattern.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }   
        public int CategoryId { get; set; }
        public int Test2 { get; set; }

        public Category Category { get; set; }

    }
}