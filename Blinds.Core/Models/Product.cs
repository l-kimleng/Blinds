using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinds.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
