using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blinds.Core.Models;

namespace Blinds.Core.Persistences.Repositories
{
    public interface IProductRepository
    {
        Task<IList<Product>> Get(ProductQuery query);
    }
}
