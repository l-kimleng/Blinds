using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blinds.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string BrandName { get; set; }
    }
}