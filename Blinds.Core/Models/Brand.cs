using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinds.Core.Models
{
    public class Brand
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
