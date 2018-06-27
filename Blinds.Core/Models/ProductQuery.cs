using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinds.Core.Models
{
    public class ProductQuery
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public bool IsSortAscending { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
    }
}
