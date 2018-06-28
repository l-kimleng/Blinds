using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Blinds.Core.Models;
using Blinds.Core.Persistences;
using Blinds.Core.Persistences.Repositories;
using Blinds.ViewModels;

namespace Blinds.Controllers
{
    [RoutePrefix("api/Products")]
    public class ProductsController : ApiController
    {
        private readonly BlindsDbContext _context;

        public ProductsController()
        {
            _context = BlindsDbContext.Create();
        }

        private IProductRepository _productRepository;

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    return _productRepository = new ProductRepository(_context);
                }
                return _productRepository;
            }
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get([FromUri] ProductQuery query)
        {
            var result = await ProductRepository.Get(query);
            var list = result.Select(r => new ProductViewModel
                {
                    Id = r.Id,
                    Price = r.Price,
                    Name = r.Name,
                    BrandName = r.Brand.Name
                }).ToList();

            return Ok(new {total = result.Count, data = list});
        }
    }
}
