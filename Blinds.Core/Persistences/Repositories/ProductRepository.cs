using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blinds.Core.Models;

namespace Blinds.Core.Persistences.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BlindsDbContext _context;

        public ProductRepository(BlindsDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Product>> Get(ProductQuery query)
        {
            var result = new List<Product>();

            if (query != null)
            {
                var queryable = _context.Products.AsQueryable();

                // Apply sorting
                queryable = query.IsSortAscending
                    ? queryable.OrderBy(x => x.Price)
                    : queryable.OrderByDescending(x => x.Price);

                // Apply paging
                var page = query.Page;
                var size = query.PageSize;
                if (page <= 0) page = 1;
                if (size <= 0) size = 5;

                queryable = queryable.Skip((page - 1) * size).Take(size);

                if (query.BrandId > 0)
                {
                    queryable = queryable.Where(x => x.BrandId == query.BrandId);
                }

                if (!string.IsNullOrEmpty(query.Name))
                {
                    var listByName = await queryable.Where(x => x.Name.Contains(query.Name)).ToListAsync();
                    result.AddRange(listByName);
                }
            }

            return result;
        }
    }
}
